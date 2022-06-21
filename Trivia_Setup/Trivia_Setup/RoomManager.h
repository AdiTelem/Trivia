#pragma once

#include <vector>
#include <map>
#include <string>

#include "Room.h"

#define ACTIVE 1
#define WAITING 0

using std::vector;
using std::map;
using std::string;

class RoomManager
{
public:
	RoomManager();
	Room createRoom(LoggedUser user, RoomData roomData);
	void deleteRoom(int ID);
	unsigned int getRoomState(int ID);
	vector<RoomData> getRooms();
	Room getRoom(unsigned int id);
	vector<string> getRoomPlayers(unsigned int roomId);
	Room addPlayerToRoom(unsigned int roomId, LoggedUser user);
	void removePlayerFromRoom(unsigned int roomId, LoggedUser user);
	bool doesRoomExists(unsigned int roomId);

	static unsigned int idCount;
private:
	
	map<unsigned int, Room> m_rooms; //<roomID, Room>
};

