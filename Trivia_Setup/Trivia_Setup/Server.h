#pragma once

#include "Communicator.h"

#define PORT 6969

class Server
{
public:
	Server();
	~Server();

	void run();
private:
	IDatabase* m_database;
	RequestHandlerFactory m_handlerFactory;
	Communicator* m_communicator;
};

