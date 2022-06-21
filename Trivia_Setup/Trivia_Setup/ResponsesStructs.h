#pragma once

#include <string>
#include <vector>

#include "RoonData.h"

using std::vector;


typedef struct
{
	char* messege;
} ErrorResponse;


typedef struct
{
	unsigned char status;
} LoginResponse;


typedef struct
{
	unsigned char status;
} SignupResponse;

typedef struct
{
	unsigned int status;
} LogoutResponse;

typedef struct
{
	unsigned int status;
	vector<RoomData> rooms;
} GetRoomsResponse;

typedef struct
{
	vector<string> players;
} GetPlayersInRoomResponse;

typedef struct
{
	unsigned int status;
	vector<string> statistics;
} GetHighScoreResponse;

typedef struct
{
	unsigned int status;
	vector<string> statistics;
} GetPersonalStatsResponse;

typedef struct
{
	unsigned int status;
} JoinRoomResponse;

typedef struct
{
	unsigned int status;
} CreateRoomResponse;

typedef struct
{
	unsigned int status;
} CloseRoomResponse;

typedef struct
{
	unsigned int status;
} StartGameResponse;

typedef struct
{
	unsigned int status;
} LeaveRoomResponse;

typedef struct
{
	unsigned int status;
	bool hasGameBegun;
	unsigned int questionCount;
	unsigned int answerTimeout;
	std::vector<string> players;
} GetRoomStateResponse;
