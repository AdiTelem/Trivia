#include "LoginRequestHandler.h"

LoginRequestHandler::LoginRequestHandler(LoginManager& loginManager, RequestHandlerFactory& handlerFactory):
	m_loginManager(loginManager), m_handleFactory(handlerFactory)
{
}

bool LoginRequestHandler::isRequestRelevant(RequestInfo reqInfo)
{
	if ((int)reqInfo.buffer[0] == LOGIN_CODE || (int)reqInfo.buffer[0] == SIGNUP_CODE)
	{
		return true;
	}
	return false;
}

RequestResult LoginRequestHandler::handleRequest(RequestInfo reqInfo)
{
	RequestResult result;

	if ((int)reqInfo.buffer[0] == LOGIN_CODE)
	{
		result = login(reqInfo);
	}
	else
	{
		if ((int)reqInfo.buffer[0] == SIGNUP_CODE)
		{
			result = signup(reqInfo);
		}
	}

	return result;
}

RequestResult LoginRequestHandler::login(RequestInfo reqInfo)
{
	RequestResult reqResult;
	LoginResponse loginResponse;
	LoginRequest loginInfo;
	char* messageInfo;
	int length = 0;

	memcpy(&length, reqInfo.buffer + 1, 4);
	messageInfo = new char[length];
	memcpy(messageInfo, reqInfo.buffer + 5, length);

	loginInfo = Deserializer::deserializeLoginRequest(messageInfo);
	try
	{
		m_loginManager.login(loginInfo.username, loginInfo.password);
		loginResponse = { SUCCEED_STATUS };
		reqResult = { Serializer::serializeResponse(loginResponse), m_handleFactory.createMenuRequestHandler(LoggedUser(loginInfo.username))};
	}
	catch (std::exception err)
	{
		loginResponse = { LOGIN_FAILED };
		reqResult = { Serializer::serializeResponse(loginResponse), m_handleFactory.createLoginRequestHandler() };
	}

	delete[] messageInfo;

	return reqResult;
}

RequestResult LoginRequestHandler::signup(RequestInfo reqInfo)
{
	RequestResult reqResult;
	SignupResponse signupResponse;
	SignupRequest signupInfo;
	char* messageInfo;
	int length = 0;

	memcpy(&length, reqInfo.buffer + 1, 4);
	messageInfo = new char[length];
	memcpy(messageInfo, reqInfo.buffer + 5, length);

	signupInfo = Deserializer::deserializeSignupRequest(messageInfo);
	try
	{
		m_loginManager.signup(signupInfo.username, signupInfo.password, signupInfo.email);
		signupResponse = { SUCCEED_STATUS };
		reqResult = { Serializer::serializeResponse(signupResponse), m_handleFactory.createLoginRequestHandler() };
	}
	catch (std::exception err)
	{
		signupResponse = { SIGNUP_FAILED };
		reqResult = {Serializer::serializeResponse(signupResponse), m_handleFactory.createLoginRequestHandler() };
	}

	delete[] messageInfo;

	return reqResult;
}
