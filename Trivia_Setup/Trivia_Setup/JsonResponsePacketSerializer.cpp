#include "JsonResponsePacketSerializer.h"


char* Serializer::serializeResponse(ErrorResponse errResponse)
{
    json jsonResponse;

    jsonResponse["message"] = errResponse.messege;

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), ERROR_CODE);

    return response;
}

char* Serializer::serializeResponse(LoginResponse loginResponse)
{
    json jsonResponse;

    jsonResponse["status"] = loginResponse.status;

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), LOGIN_CODE);

    return response;
}

char* Serializer::serializeResponse(SignupResponse signupResponse)
{
    json jsonResponse;

    jsonResponse["status"] = signupResponse.status;

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), SIGNUP_CODE);

    return response;
}

char* Serializer::serializeResponse(LogoutResponse logoutResponse)
{
    json jsonResponse;

    jsonResponse["status"] = logoutResponse.status;

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), SIGNOUT_CODE);

    return response;
}

char* Serializer::serializeResponse(GetRoomsResponse getRoomResponse)
{
    json jsonResponse;

    jsonResponse["status"] = getRoomResponse.status;
    jsonResponse["rooms"] = json::array();
    for (RoomData roomData : getRoomResponse.rooms)
    {
        json jsonRoom;
        jsonRoom["room"]["id"] = roomData.id;
        jsonRoom["room"]["isActive"] = roomData.isActive;
        jsonRoom["room"]["maxPlayers"] = roomData.maxPlayers;
        jsonRoom["room"]["name"] = roomData.name;
        jsonRoom["room"]["numOfQuestionsinGame"] = roomData.numOfQuestionsinGame;
        jsonRoom["room"]["timePerQuestion"] = roomData.timePerQuestion;
        jsonResponse["rooms"].push_back(jsonRoom);
    }

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), GET_ROOMS_CODE);

    return response;
}

char* Serializer::serializeResponse(GetPlayersInRoomResponse getPlayersInRoomResponse)
{
    json jsonResponse;

    jsonResponse = json::array();
    for (string player : getPlayersInRoomResponse.players)
    {
        json jsonRoom;
        jsonRoom["player"] = player;
        jsonResponse.push_back(jsonRoom);
    }

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), GET_PLAYERS_IN_ROOM_CODE);

    return response;
}

char* Serializer::serializeResponse(JoinRoomResponse joinRoomResponse)
{
    json jsonResponse;

    jsonResponse["status"] = joinRoomResponse.status;

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), JOIN_ROOM_CODE);

    return response;
}

char* Serializer::serializeResponse(CreateRoomResponse createRoomResponse)
{
    json jsonResponse;

    jsonResponse["status"] = createRoomResponse.status;

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), CREATE_ROOM_CODE);

    return response;
}

char* Serializer::serializeResponse(GetPersonalStatsResponse getPersonalStatsResponse)
{
    json jsonResponse;

    jsonResponse["status"] = getPersonalStatsResponse.status;
    jsonResponse["UserStatistics"] = json::array();

    for (string stat : getPersonalStatsResponse.statistics)
    {
        json jsonStat;
        jsonStat["stat"] = stat;
        jsonResponse["UserStatistics"].push_back(jsonStat);
    }

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), GET_PERSONAL_STATS_CODE);

    return response;
}

char* Serializer::serializeResponse(GetHighScoreResponse getHighScoreResponse)
{
    json jsonResponse;

    jsonResponse["status"] = getHighScoreResponse.status;
    jsonResponse["UserStatistics"] = json::array();
    for (string stat : getHighScoreResponse.statistics)
    {
        json jsonStat;
        jsonStat["stat"] = stat;
        jsonResponse["UserStatistics"].push_back(jsonStat);
    }

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), GET_HIGH_SCORES_CODE);

    return response;
}

char* Serializer::serializeResponse(CloseRoomResponse closeRoomResponse)
{
    json jsonResponse;

    jsonResponse["status"] = closeRoomResponse.status;

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), CLOSE_ROOM_CODE);

    return response;
}

char* Serializer::serializeResponse(StartGameResponse startGameResponse)
{
    json jsonResponse;

    jsonResponse["status"] = startGameResponse.status;

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), START_GAME_CODE);

    return response;
}

char* Serializer::serializeResponse(LeaveRoomResponse leaveRoomResponse)
{
    json jsonResponse;

    jsonResponse["status"] = leaveRoomResponse.status;

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), LEAVE_ROOM_CODE);

    return response;
}

char* Serializer::serializeResponse(GetRoomStateResponse getRoomStateResponse)
{
    json jsonResponse;

    jsonResponse["status"] = getRoomStateResponse.status;
    jsonResponse["hasGameBegun"] = getRoomStateResponse.hasGameBegun;
    jsonResponse["questionCount"] = getRoomStateResponse.questionCount;
    jsonResponse["hasGameBegun"] = getRoomStateResponse.hasGameBegun;
    jsonResponse["Players"] = json::array();
    for (string player : getRoomStateResponse.players)
    {
        json jsonPlayer;
        jsonPlayer["player"] = player;
        jsonResponse["Players"].push_back(jsonPlayer);
    }

    std::string strJson = jsonResponse.dump();
    char* response = packData(strJson, strJson.size(), GET_ROOMS_CODE);

    return response;
}

char* Serializer::packData(std::string json, int size, int code)
{
    char* chrJson = (char*)json.c_str();
    char* finalResponse = new char[CODE_SIZE + SIZE_SIZE + size * sizeof(char)];
    finalResponse[0] = (char)SIGNUP_CODE;
    memcpy(finalResponse + CODE_SIZE, &size, SIZE_SIZE);
    memcpy(finalResponse + CODE_SIZE + SIZE_SIZE, chrJson, size);

    return finalResponse;
}
