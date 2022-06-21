#pragma once

#include "RequestStructs.h"
#include <iostream>

#define CODE_SIZE 1
#define SIZE_SIZE 4

#define USERNAME_KEY "\"username\":"
#define PASSWORD_KEY "\"password\":"
#define EMAIL_KEY "\"email\":"
#define ROOMID_KEY "\"roomId\":"
#define ROOMNAME_KEY "\"roomName\":"
#define MAXUSERS_KEY "\"maxUsers\":"
#define QUESTIONCOUNT_KEY "\"questionCount\":"
#define ANSWERTIMEOUT_KEY "\"answerTimeOut\":"

class Deserializer
{
public:
	static LoginRequest deserializeLoginRequest(char* bJson);
	static SignupRequest deserializeSignupRequest(char* bJson);
	static GetPlayersInRoomRequest deserializeGetPlayersInRoomRequest(char* bJson);
	static JoinRoomRequest deserializeJoinRoomRequest(char* bJson);
	static CreateRoomRequest deserializeCreateRoomRequest(char* bJson);
private:
	static std::string getJsonFromRequest(char* request);
	static std::string getDataFromJson(std::string json, std::string key); 
};

