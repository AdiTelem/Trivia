#pragma once


#include <WinSock2.h>
#include <Windows.h>
#include <iostream>
#include <algorithm>
#include <thread>
#include <mutex>
#include <vector>
#include <map>
#include <time.h>

#include "CommunicatorHelper.h"
#include "JsonRequestPacketDeserializer.h"
#include "JsonResponsePacketSerializer.h"
#include "RequestHandlerFactory.h"
#include "RequestInfo.h"
#include "RequestResult.h"

#define DEFAULT_PORT 6969


using std::map;
using std::vector;
using std::string;
using std::thread;

class Communicator
{
public:
	Communicator(RequestHandlerFactory& reqHandlerFactory, int port=DEFAULT_PORT);
	Communicator(RequestHandlerFactory& reqHandlerFactory, bool Init);
	~Communicator();
	void startHandleRequests();

private:
	static int id;
	void bindAndListen();
	void handleNewClient(SOCKET sock);

	SOCKET m_serverSocket;
	vector<thread> _clientsThreads;
	int _listenPort;
	map<SOCKET, IRequestHandler*> m_clients;
	RequestHandlerFactory& m_handlerFactory;
};

