#pragma comment(lib, "Ws2_32.lib")

#include <iostream>
#include <stdio.h>
#include <stdlib.h>

#include "WSAInitializer.h"
#include "Server.h"

#include "JsonResponsePacketSerializer.h"
#include "JsonRequestPacketDeserializer.h"

int main(void)
{
	try
	{
		WSAInitializer wsaInit;
		Server server = Server();

		server.run();
	}
	catch (std::exception& e)
	{
		std::cout << "Error occured: " << e.what() << std::endl;
	}

	system("PAUSE");
	getchar();
	return 0;
}