#pragma once

#include <iostream>
#include <string>
#include <WinSock2.h>

class CommunicatorHelper
{
public:
	CommunicatorHelper();
	~CommunicatorHelper();

	bool sendData(SOCKET sc, std::string message, bool throwError=(true));
	void sendData(SOCKET sc, char* message, int bytesNum);
	std::string recvDataStr(SOCKET sc, int bytesNum, int flags=0);
	char* recvData(SOCKET sc, int bytesNum, int flags=0);
	char* getCode(SOCKET sc);
	char* getLength(SOCKET sc);
	char* getMessage(SOCKET sc);
	char* getWholeData(SOCKET sc);
private:

};