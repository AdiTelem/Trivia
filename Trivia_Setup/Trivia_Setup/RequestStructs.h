#pragma once

#include <string>

using std::string;

typedef struct
{
	string username;
	string password;
} LoginRequest;


typedef struct
{
	string username;
	string password;
	string email;
} SignupRequest;




typedef struct
{
	unsigned int roomId;
} GetPlayersInRoomRequest;


typedef struct
{
	unsigned int roomId;
} JoinRoomRequest;


typedef struct
{
	string roomName;
	unsigned int maxUsers;
	unsigned int questionCount;
	unsigned int answerTimeOut;
} CreateRoomRequest;


