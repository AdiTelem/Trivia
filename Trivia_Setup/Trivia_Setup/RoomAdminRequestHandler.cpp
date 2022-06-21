#include "RoomAdminRequestHandler.h"

RoomAdminRequestHandler::RoomAdminRequestHandler(LoggedUser user, Room room, RequestHandlerFactory& handlerFactory, RoomManager& roomManager):
    m_user(user), m_room(room), m_requestHandlerFactory(handlerFactory), m_roomManager(roomManager)
{
}

bool RoomAdminRequestHandler::isRequestRelevant(RequestInfo reqInfo)
{
    if ((int)reqInfo.buffer[0] == GET_ROOM_STATE_CODE)
        return true;

    if ((int)reqInfo.buffer[0] == CLOSE_ROOM_CODE)
        return true;

    if ((int)reqInfo.buffer[0] == START_GAME_CODE)
        return true;

    return false;
}

RequestResult RoomAdminRequestHandler::handleRequest(RequestInfo reqInfo)
{
    RequestResult result;

    switch ((int)reqInfo.buffer[0])
    {
    case GET_ROOM_STATE_CODE:
        result = getRoomState(reqInfo);
        break;
    case CLOSE_ROOM_CODE:
        result = closeRoom(reqInfo);
        break;
    case START_GAME_CODE:
        result = startGame(reqInfo);
        break;
    case GET_PLAYERS_IN_ROOM_CODE:
        result = getPlayersInRoom(reqInfo);
        break;
    default:
        
        result = RequestResult{ (char*)std::to_string(ERROR_CODE).c_str() , m_requestHandlerFactory.createRoomAdminRequestHandler(m_room, m_user) };
        break;
    }


    return result;
}
RequestResult RoomAdminRequestHandler::closeRoom(RequestInfo reqInfo)
{
    m_roomManager.deleteRoom(m_room.getId());
    CloseRoomResponse closeRoomResponse = { SUCCEED_STATUS };
    return RequestResult{ Serializer::serializeResponse(closeRoomResponse), m_requestHandlerFactory.createMenuRequestHandler(m_user) };
}

RequestResult RoomAdminRequestHandler::startGame(RequestInfo reqInfo)
{
    //m_roomManager.startRoom(m_room.getId()); TODO: make it start the game
    StartGameResponse startRoomResponse = { SUCCEED_STATUS };
    return RequestResult{ Serializer::serializeResponse(startRoomResponse), m_requestHandlerFactory.createMenuRequestHandler(m_user) }; //TODO: change to game handler
}

RequestResult RoomAdminRequestHandler::getRoomState(RequestInfo reqInfo)
{
    GetRoomStateResponse roomStateResponse;
    RequestResult reqResult;

    if (m_roomManager.doesRoomExists(m_room.getId()))
    {
        roomStateResponse = { SUCCEED_STATUS, (bool)m_room.getState(), m_room.getRoomData().numOfQuestionsinGame, m_room.getRoomData().timePerQuestion, m_room.getAllUsers() };
        reqResult = { Serializer::serializeResponse(roomStateResponse), m_requestHandlerFactory.createRoomAdminRequestHandler(m_room, m_user) };
    }
    else
    {
        roomStateResponse = { ROOM_DOESNT_EXIST };
        reqResult = { Serializer::serializeResponse(roomStateResponse), m_requestHandlerFactory.createMenuRequestHandler(m_user) };
    }

    return reqResult;
}


RequestResult RoomAdminRequestHandler::getPlayersInRoom(RequestInfo reqInfo)
{
    RequestResult reqResult;
    GetPlayersInRoomResponse roomPlayerResponse;
    GetPlayersInRoomRequest roomInfo;
    std::vector<string> players;
    char* messageInfo;
    int length = 0;

    memcpy(&length, reqInfo.buffer + 1, 4);
    messageInfo = new char[length];
    memcpy(messageInfo, reqInfo.buffer + 5, length);

    roomInfo = Deserializer::deserializeGetPlayersInRoomRequest(messageInfo);
    roomPlayerResponse = { m_roomManager.getRoomPlayers(roomInfo.roomId) };

    reqResult = { Serializer::serializeResponse(roomPlayerResponse), m_requestHandlerFactory.createRoomMemberRequestHandler(m_room, m_user) };

    return reqResult;
}