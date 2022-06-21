#pragma once

#include "IRequestHandler.h"
#include "RequestHandlerFactory.h"
#include "JsonRequestPacketDeserializer.h"
#include "JsonResponsePacketSerializer.h"

class LoginManager;
class RequestHandlerFactory;
class LoginRequestHandler : public IRequestHandler
{
public:
	LoginRequestHandler(LoginManager& loginManager, RequestHandlerFactory& handlerFactory);
	bool isRequestRelevant(RequestInfo reqInfo);
	RequestResult handleRequest(RequestInfo reqInfo);

private:
	RequestResult login(RequestInfo reqInfo);
	RequestResult signup(RequestInfo reqInfo);

	LoginManager& m_loginManager;
	RequestHandlerFactory& m_handleFactory;
};


