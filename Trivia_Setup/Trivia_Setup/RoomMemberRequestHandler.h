#pragma once
#include "RequestHandlerFactory.h"
#include "JsonRequestPacketDeserializer.h"
#include "JsonResponsePacketSerializer.h"


class RoomManager;
class RequestHandlerFactory;
class RoomMemberRequestHandler : public IRequestHandler
{
public:
	RoomMemberRequestHandler(LoggedUser user, Room room, RequestHandlerFactory& handlerFactory, RoomManager& roomManager);
	bool isRequestRelevant(RequestInfo reqInfo);
	RequestResult handleRequest(RequestInfo reqInfo);


private:
	Room m_room;
	LoggedUser m_user;
	RoomManager& m_roomManager;
	RequestHandlerFactory& m_requestHandlerFactory;

	RequestResult leaveRoom(RequestInfo reqInfo);
	RequestResult getRoomState(RequestInfo reqInfo);
	RequestResult getPlayersInRoom(RequestInfo reqInfo);
};

