#include "Server.h"

Server::Server():
	m_database(new SqliteDatabase()),
	m_handlerFactory(RequestHandlerFactory(m_database)),
	m_communicator(new Communicator(m_handlerFactory, PORT))
{

}

Server::~Server()
{
	delete m_communicator;
	delete m_database;
}

void Server::run()
{
	std::cout << "running..." << std::endl;
	m_communicator->startHandleRequests();
}
