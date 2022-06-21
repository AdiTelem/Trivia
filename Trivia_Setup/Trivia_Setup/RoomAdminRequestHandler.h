#pragma once
#include "RequestHandlerFactory.h"
#include "JsonRequestPacketDeserializer.h"
#include "JsonResponsePacketSerializer.h"


class RoomManager;
class RequestHandlerFactory;
class RoomAdminRequestHandler : public IRequestHandler
{
public:
	RoomAdminRequestHandler(LoggedUser user, Room room, RequestHandlerFactory& handlerFactory, RoomManager& roomManager);
	bool isRequestRelevant(RequestInfo reqInfo);
	RequestResult handleRequest(RequestInfo reqInfo);

private:
	Room m_room;
	LoggedUser m_user;
	RoomManager& m_roomManager;
	RequestHandlerFactory& m_requestHandlerFactory;

    RequestResult getPlayersInRoom(RequestInfo reqInfo);
    RequestResult closeRoom(RequestInfo reqInfo);
    RequestResult startGame(RequestInfo reqInfo);
    RequestResult getRoomState(RequestInfo reqInfo);
};
