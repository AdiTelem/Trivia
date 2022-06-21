#pragma once
#include "RequestHandlerFactory.h"
#include "JsonRequestPacketDeserializer.h"
#include "JsonResponsePacketSerializer.h"


class RoomManager;
class RequestHandlerFactory;
class StatisticsManager;
class MenuRequestHandler : public IRequestHandler
{
public:
	MenuRequestHandler(LoggedUser user, RoomManager& roomManager, StatisticsManager& statsManager, LoginManager& loginManager, RequestHandlerFactory& reHandFac);
	bool isRequestRelevant(RequestInfo reqInfo);
	RequestResult handleRequest(RequestInfo reqInfo);

private:
	RequestResult signout(RequestInfo reqInfo);
	RequestResult getRooms(RequestInfo reqInfo);
	RequestResult getPlayersInRoom(RequestInfo reqInfo);
	RequestResult getPersonalStats(RequestInfo reqInfo);
	RequestResult getHighScores(RequestInfo reqInfo);
	RequestResult joinRoom(RequestInfo reqInfo);
	RequestResult createRoom(RequestInfo reqInfo);

	LoginManager& m_loginManager;
	RoomManager& m_roomManager;
	StatisticsManager& m_statisticsManager;
	LoggedUser m_user;
	RequestHandlerFactory& m_requestHandlerFactory;
};

