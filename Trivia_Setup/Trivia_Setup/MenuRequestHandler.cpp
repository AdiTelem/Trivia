#include "MenuRequestHandler.h"

MenuRequestHandler::MenuRequestHandler(LoggedUser user, RoomManager& roomManager, StatisticsManager& statsManager, LoginManager& loginManager, RequestHandlerFactory& reHandFac) :
    m_roomManager(roomManager), m_statisticsManager(statsManager), m_user(user), m_requestHandlerFactory(reHandFac), m_loginManager(loginManager)
{
}

bool MenuRequestHandler::isRequestRelevant(RequestInfo reqInfo)
{
    if ((int)reqInfo.buffer[0] == SIGNOUT_CODE)
        return true;

    if ((int)reqInfo.buffer[0] == GET_HIGH_SCORES_CODE)
        return true;

    if ((int)reqInfo.buffer[0] == GET_PERSONAL_STATS_CODE)
        return true;

    if ((int)reqInfo.buffer[0] == GET_PLAYERS_IN_ROOM_CODE)
        return true;

    if ((int)reqInfo.buffer[0] == GET_ROOMS_CODE)
        return true;

    if ((int)reqInfo.buffer[0] == JOIN_ROOM_CODE)
        return true;

    if ((int)reqInfo.buffer[0] == CREATE_ROOM_CODE)
        return true;


    return false;
}

RequestResult MenuRequestHandler::handleRequest(RequestInfo reqInfo)
{
    RequestResult result;

    switch ((int)reqInfo.buffer[0])
    {
    case SIGNOUT_CODE:
        result = signout(reqInfo);
        break;
    case GET_ROOMS_CODE:
        result = getRooms(reqInfo);
        break;
    case GET_PLAYERS_IN_ROOM_CODE:
        result = getPlayersInRoom(reqInfo);
        break;
    case GET_PERSONAL_STATS_CODE:
        result = getPersonalStats(reqInfo);
        break;
    case GET_HIGH_SCORES_CODE:
        result = getHighScores(reqInfo);
        break;
    case JOIN_ROOM_CODE:
        result = joinRoom(reqInfo);
        break;
    case CREATE_ROOM_CODE:
        result = createRoom(reqInfo);
        break;
    default:
        result = RequestResult{ (char*)std::to_string(ERROR_CODE).c_str() , m_requestHandlerFactory.createMenuRequestHandler(LoggedUser(m_user))};
        break;
    }


    return result;
}

RequestResult MenuRequestHandler::signout(RequestInfo reqInfo)
{
    m_loginManager.logout(m_user.getUsername());
    LogoutResponse logoutResponse = { SUCCEED_STATUS };
    return RequestResult{Serializer::serializeResponse(logoutResponse), m_requestHandlerFactory.createLoginRequestHandler()};
}

RequestResult MenuRequestHandler::getRooms(RequestInfo reqInfo)
{
    GetRoomsResponse response;

    response.rooms = m_roomManager.getRooms();

    if (response.rooms.empty())
    {
        response.status = NO_ROOMS;
    }
    else
    {
        response.status =  SUCCEED_STATUS ;
    }

    return RequestResult{ Serializer::serializeResponse(response), m_requestHandlerFactory.createMenuRequestHandler(LoggedUser(m_user)) };
}

RequestResult MenuRequestHandler::getPlayersInRoom(RequestInfo reqInfo)
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

    reqResult = { Serializer::serializeResponse(roomPlayerResponse), m_requestHandlerFactory.createMenuRequestHandler(LoggedUser(m_user)) };

    return reqResult;
}

RequestResult MenuRequestHandler::getPersonalStats(RequestInfo reqInfo)
{
    RequestResult reqResult;
    GetPersonalStatsResponse personalStatsResponse;

    StatisticsInfo info = m_statisticsManager.getPersonalStatistics(m_user.getUsername());
    personalStatsResponse = { SUCCEED_STATUS, {"Games Played " + std::to_string(info.gamesAmount), "Average Answer Time " + std::to_string(info.averageAnswerTime), "Total Answers " + std::to_string(info.totalAnswers), "Correct Answers " + std::to_string(info.correctAnswers)} };

    reqResult = { Serializer::serializeResponse(personalStatsResponse), m_requestHandlerFactory.createMenuRequestHandler(LoggedUser(m_user)) };

    return reqResult;
}

RequestResult MenuRequestHandler::getHighScores(RequestInfo reqInfo)
{
    RequestResult reqResult;
    GetHighScoreResponse highScoreResponse;

    highScoreResponse = {SUCCEED_STATUS ,m_statisticsManager.getHighScore() };
    reqResult = { Serializer::serializeResponse(highScoreResponse), m_requestHandlerFactory.createMenuRequestHandler(LoggedUser(m_user)) };

    return reqResult;
}

RequestResult MenuRequestHandler::joinRoom(RequestInfo reqInfo)
{
    RequestResult reqResult;
    JoinRoomResponse joinResponse;
    JoinRoomRequest joinReq;
    std::vector<string> players;
    char* messageInfo;
    int length = 0;

    memcpy(&length, reqInfo.buffer + 1, 4);
    messageInfo = new char[length];
    memcpy(messageInfo, reqInfo.buffer + 5, length);

    joinReq = Deserializer::deserializeJoinRoomRequest(messageInfo);
    if (m_roomManager.addPlayerToRoom(joinReq.roomId, m_user).getId() != 0)
    {
        std::cout << "x" << std::endl;
        joinResponse = { SUCCEED_STATUS };
        reqResult = { Serializer::serializeResponse(joinResponse), m_requestHandlerFactory.createRoomMemberRequestHandler(m_roomManager.getRoom(joinReq.roomId), LoggedUser(m_user)) }; //change "this" to RoomMemeber Handler
        std::cout << "x" << std::endl;
    }
    else
    {
        joinResponse = { ROOM_DOESNT_EXIST };
        reqResult = { Serializer::serializeResponse(joinResponse), m_requestHandlerFactory.createMenuRequestHandler(LoggedUser(m_user)) };
    }

    return reqResult;
}

RequestResult MenuRequestHandler::createRoom(RequestInfo reqInfo)
{
    RequestResult reqResult;
    CreateRoomRequest createReq;
    CreateRoomResponse createResponse;
    RoomData roomData;
    std::vector<string> players;
    char* messageInfo;
    int length = 0;

    memcpy(&length, reqInfo.buffer + 1, 4);
    messageInfo = new char[length];
    memcpy(messageInfo, reqInfo.buffer + 5, length);

    createReq = Deserializer::deserializeCreateRoomRequest(messageInfo);
    roomData = {RoomManager::idCount, createReq.roomName, createReq.maxUsers, createReq.questionCount, createReq.answerTimeOut };
    Room room = m_roomManager.createRoom(m_user, roomData);
    createResponse = { roomData.id };
    reqResult = { Serializer::serializeResponse(createResponse), m_requestHandlerFactory.createRoomAdminRequestHandler(room, m_user) }; //change "this" to RoomAdmin Handler

    return reqResult;
}
