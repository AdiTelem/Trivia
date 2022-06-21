#include "Room.h"

Room::Room()
{
}

Room::Room(RoomData roomData, vector<LoggedUser> users) :
	m_metadata(roomData), m_users(users)
{
}

Room::Room(RoomData roomData, LoggedUser user) :
	m_metadata(roomData), m_users(vector<LoggedUser>(1, user))
{
}

void Room::addUser(LoggedUser user)
{
	m_users.push_back(user);
}

void Room::removeUser(LoggedUser user)
{
	vector<LoggedUser>::iterator userIter = std::find(m_users.begin(), m_users.end(), user);
	if ((userIter == m_users.end() && (*userIter) == user) || userIter != m_users.end())
	{
		m_users.erase(userIter);
	}
}

vector<string> Room::getAllUsers()
{
	vector<string> usersString;

	for (LoggedUser user : m_users)
	{
		usersString.push_back(user.getUsername());
	}

	return usersString;
}

RoomData Room::getRoomData()
{
	return m_metadata;
}

unsigned int Room::getId()
{
	return m_metadata.id;
}

unsigned int Room::getState()
{
	return m_metadata.isActive;
}
