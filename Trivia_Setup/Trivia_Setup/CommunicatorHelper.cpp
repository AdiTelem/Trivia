#include "CommunicatorHelper.h"

CommunicatorHelper::CommunicatorHelper()
{
}

CommunicatorHelper::~CommunicatorHelper()
{
}

bool CommunicatorHelper::sendData(SOCKET sc, std::string message, bool throwError)
{
	const char* data = message.c_str();

	if (send(sc, data, message.size(), 0) == INVALID_SOCKET)
	{
		if (throwError)
		{
			throw std::exception("Failed sending message socket invalid.");
		}
		return false; //fail
	}

	return true; //succeed
}


void CommunicatorHelper::sendData(SOCKET sc, char* message, int bytesNum)
{
	const char* data = message;

	if (send(sc, data, bytesNum, 0) == INVALID_SOCKET)
	{
		throw std::exception("Failed sending message socket invalid.");
	}
}

std::string CommunicatorHelper::recvDataStr(SOCKET sc, int bytesNum, int flags)
{
	if (bytesNum == 0)
	{
		return std::string("");
	}

	char* data = new char[bytesNum + 1];
	int res = recv(sc, data, bytesNum, flags);

	if (res == INVALID_SOCKET)
	{
		std::string s = "Error while recieving from socket: ";
		s += std::to_string(sc);
		throw std::exception(s.c_str());
	}

	data[bytesNum] = 0;
	return std::string(data);
}

char* CommunicatorHelper::recvData(SOCKET sc, int bytesNum, int flags)
{
	char* data = new char[bytesNum + 1];
	
	if (bytesNum == 0)
	{
		return data;
	}

	int res = recv(sc, data, bytesNum, flags);

	if (res == INVALID_SOCKET)
	{
		std::string s = "Error while recieving from socket: ";
		s += std::to_string(sc);
		throw std::exception(s.c_str());
	}

	data[bytesNum] = 0;
	return data;
}

char* CommunicatorHelper::getCode(SOCKET sc)
{
	return recvData(sc, 1);
}

char* CommunicatorHelper::getLength(SOCKET sc)
{
	return recvData(sc, 4);
}

char* CommunicatorHelper::getMessage(SOCKET sc)
{
	char* bLength = getLength(sc);
	int length = 0;

	memcpy(&length, bLength, 4);

	char* data = new char[length];
	data = recvData(sc, length);

	return data;
}

char* CommunicatorHelper::getWholeData(SOCKET sc)
{
	char* code = getCode(sc);
	char* bLength = getLength(sc);
	int length = 0;
	char* messege = nullptr;
	char* data = nullptr;

	memcpy(&length, bLength, 4);

	messege = new char[length];
	messege = recvData(sc, length);

	data = new char[length + 5];

	memcpy(data, code, 1);
	memcpy(data + 1, bLength, 4);
	memcpy(data + 5, messege, length);

	return data;
}



