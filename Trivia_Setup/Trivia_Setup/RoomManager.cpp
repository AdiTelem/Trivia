#include "RoomManager.h"
unsigned int RoomManager::idCount = 1;

RoomManager::RoomManager()
{
	createRoom(LoggedUser("pi"), RoomData{ 1,"pita",3,4,5,1 });
	createRoom(LoggedUser("pi"), RoomData{ 4,"pita2",5,6,7,1 });
	addPlayerToRoom(1, LoggedUser("po"));
}

Room RoomManager::createRoom(LoggedUser user, RoomData roomData)
{
	roomData.isActive = 1;
	idCount++;
	Room room = Room(roomData, user);
	m_rooms.insert(std::pair<unsigned int, Room>(room.getId(), room));
	return room;
}

void RoomManager::deleteRoom(int ID)
{
	m_rooms.erase(ID);
}

unsigned int RoomManager::getRoomState(int ID)
{
	return m_rooms[ID].getState();
}

vector<RoomData> RoomManager::getRooms()
{
	vector<RoomData> rooms;

	for (std::pair<unsigned int, Room> idRoomPair : m_rooms)
	{
		if (getRoomState(idRoomPair.first) == 1)
		{
			rooms.push_back(idRoomPair.second.getRoomData());
		}
	}

	return rooms;
}

Room RoomManager::getRoom(unsigned int id)
{
	return m_rooms[id];
}

vector<string> RoomManager::getRoomPlayers(unsigned int roomId)
{
	vector<string> players;

	for (auto& room : m_rooms)
	{
		if (room.first == roomId)
		{
			players = room.second.getAllUsers();
		}
	}

	return players;
}

Room RoomManager::addPlayerToRoom(unsigned int roomId, LoggedUser user)
{
	for (auto& room : m_rooms)
	{
		if (room.first == roomId)
		{
			room.second.addUser(user);
			return room.second;
		}
	}
	return Room(RoomData{0}, LoggedUser(""));
}

void RoomManager::removePlayerFromRoom(unsigned int roomId, LoggedUser user)
{
	for (auto room : m_rooms)
	{
		if (room.first == roomId)
		{
			room.second.removeUser(user);
		}
	}
}

bool RoomManager::doesRoomExists(unsigned int roomId)
{
	for (auto room : m_rooms)
	{
		if (room.first == roomId)
		{
			return true;
		}
	}

	return false;
}
