#pragma once

#include <string>

using std::string;

typedef struct
{
	unsigned int id;
	string name;
	unsigned int maxPlayers;
	unsigned int numOfQuestionsinGame;
	unsigned int timePerQuestion;
	unsigned int isActive;
} RoomData;
