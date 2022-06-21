#pragma once

#include "ResponsesStructs.h"
#include "json.hpp"
#include <bitset>
#include <iostream>

#define LOGIN_CODE 10
#define SIGNUP_CODE 11
#define SIGNOUT_CODE 12
#define GET_ROOMS_CODE 20
#define GET_PLAYERS_IN_ROOM_CODE 21
#define JOIN_ROOM_CODE 22
#define CREATE_ROOM_CODE 23
#define GET_PERSONAL_STATS_CODE 30
#define GET_HIGH_SCORES_CODE 31
#define CLOSE_ROOM_CODE 40
#define START_GAME_CODE 41
#define GET_ROOM_STATE_CODE 42
#define LEAVE_ROOM_CODE 43
#define EXIT_CODE 900
#define ERROR_CODE 61


#define CODE_SIZE 1
#define SIZE_SIZE 4

using json = nlohmann::json;

class Serializer
{
public:
	static char* serializeResponse(ErrorResponse errResponse);
	static char* serializeResponse(LoginResponse loginResponse);
	static char* serializeResponse(SignupResponse signupResponse);
	static char* serializeResponse(LogoutResponse logoutResponse);
	static char* serializeResponse(GetRoomsResponse getRoomResponse);
	static char* serializeResponse(GetPlayersInRoomResponse getPlayersInRoomResponse);
	static char* serializeResponse(JoinRoomResponse joinRoomResponse);
	static char* serializeResponse(CreateRoomResponse createRoomResponse);
	static char* serializeResponse(GetPersonalStatsResponse getPersonalStatsResponse);
	static char* serializeResponse(GetHighScoreResponse getHighScoreResponse);
	static char* serializeResponse(CloseRoomResponse closeRoomResponse);
	static char* serializeResponse(StartGameResponse startGameResponse);
	static char* serializeResponse(GetRoomStateResponse getRoomStateResponse);
	static char* serializeResponse(LeaveRoomResponse leaveRoomResponse);
private:
	static char* packData(std::string json, int size, int code);
};



