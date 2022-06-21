#include "Communicator.h"

int Communicator::id = 1;

Communicator::Communicator(RequestHandlerFactory& reqHandlerFactory, bool Init) :
	m_handlerFactory(reqHandlerFactory)
{
}

Communicator::Communicator(RequestHandlerFactory& reqHandlerFactory, int port):
	_listenPort(port), m_handlerFactory(reqHandlerFactory)
{
	m_serverSocket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP); //creating TCP socket

	if (m_serverSocket == INVALID_SOCKET)
		throw std::exception(__FUNCTION__ " - socket");
}

Communicator::~Communicator()
{
	try
	{
		// the only use of the destructor should be for freeing 
		// resources that was allocated in the constructor
		closesocket(m_serverSocket);
	}
	catch (...) {}
}

void Communicator::startHandleRequests()
{
	struct sockaddr_in sa = { 0 };
	vector<string>::iterator it;
	vector<thread>::iterator itr;

	sa.sin_port = htons(_listenPort); // port that server will listen for
	sa.sin_family = AF_INET;   
	sa.sin_addr.s_addr = INADDR_ANY;    // when there are few ip's for the machine. We will use always "INADDR_ANY"

	// Connects between the socket and the configuration (port and etc..)
	if (bind(m_serverSocket, (struct sockaddr*)&sa, sizeof(sa)) == SOCKET_ERROR)
		throw std::exception(__FUNCTION__ " - bind");

	// Start listening for incoming requests of clients
	if (listen(m_serverSocket, SOMAXCONN) == SOCKET_ERROR)
		throw std::exception(__FUNCTION__ " - listen");
	std::cout << "Listening on port " << _listenPort << std::endl;

	while (true)
	{
		// the main thread is only accepting clients 
		std::cout << "Waiting for client connection request" << std::endl;
		bindAndListen(); //accept request

	}
	for (itr = _clientsThreads.begin(); itr != _clientsThreads.end(); itr++)
	{
		(*itr).join();
	}
}


void Communicator::bindAndListen()
{
	// this accepts the client and create a specific socket from server to this client
	SOCKET client_socket = ::accept(m_serverSocket, NULL, NULL);

	if (client_socket == INVALID_SOCKET)
		throw std::exception(__FUNCTION__);

	std::cout << "Client accepted. Server and client can speak" << std::endl;
	m_clients.insert(std::pair<SOCKET, IRequestHandler*>(client_socket, (m_handlerFactory.createLoginRequestHandler())));
	_clientsThreads.push_back(thread (&Communicator::handleNewClient, this, client_socket));
}

void Communicator::handleNewClient(SOCKET sock)
{
	CommunicatorHelper helper;
	RequestInfo reqInfo;
	RequestResult reqResult;
	std::string stranswer("");
	char* code = nullptr;
	char* message = nullptr;
	time_t timer;

	try
	{
		while (sock)
		{
			reqInfo = { ++id, 0, helper.getWholeData(sock) };
			time(&timer);
			reqInfo.receivalTime = timer;
			switch((int)reqInfo.buffer[0]) 
			{
			case EXIT_CODE:
				std::cout << "conversation ended" << std::endl;
				break;
			case ERROR_CODE:
				std::cout << "Error Accured" << std::endl;
				break;
			default:
				reqResult = m_clients[sock]->handleRequest(reqInfo);
				int size = 0;
				memcpy(&size, reqResult.response + CODE_SIZE, SIZE_SIZE);
				helper.sendData(sock, reqResult.response, SIZE_SIZE + CODE_SIZE + size);
				delete m_clients[sock];
				m_clients[sock] = reqResult.newHandler;
			}
		}
		closesocket(sock);
	}
	catch (const std::exception& e)
	{
		std::cout << e.what() << std::endl;
		closesocket(sock);
	}
}
