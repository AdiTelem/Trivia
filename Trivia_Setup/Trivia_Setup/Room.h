#pragma once

#include <vector>
#include <string>

#include "LoggedUser.h"
#include "RoonData.h"

using std::vector;
using std::string;

class Room
{
public:
	Room();
	Room(RoomData roomData, vector<LoggedUser> users);
	Room(RoomData roomData, LoggedUser user);
	void addUser(LoggedUser user);
	void removeUser(LoggedUser user);
	vector<string> getAllUsers();
	RoomData getRoomData();

	unsigned int getId();
	unsigned int getState();
private:
	RoomData m_metadata;
	vector<LoggedUser> m_users;
};

