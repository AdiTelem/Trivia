#pragma once

#include "IDatabase.h"
#include "LoginRequestHandler.h"
#include "LoginManager.h"
#include "RoomManager.h"
#include "MenuRequestHandler.h"
#include "StatisticsManager.h"
#include "RoomAdminRequestHandler.h"
#include "RoomMemberRequestHandler.h"

class RoomAdminRequestHandler;
class RoomMemberRequestHandler;
class MenuRequestHandler;
class LoginRequestHandler;
class RequestHandlerFactory
{
public:
	RequestHandlerFactory();
	RequestHandlerFactory(IDatabase* database);
	~RequestHandlerFactory();
	LoginRequestHandler* createLoginRequestHandler();
	LoginManager& getLoginManager();
	
	MenuRequestHandler* createMenuRequestHandler(LoggedUser user);
	RoomManager& getRoomManager();
	StatisticsManager& getStatisticsManager();

	RoomAdminRequestHandler* createRoomAdminRequestHandler(Room room, LoggedUser user);
	RoomMemberRequestHandler* createRoomMemberRequestHandler(Room room, LoggedUser user);

private:
	RoomManager m_roomManager;
	StatisticsManager m_statisticsManager;
	LoginManager m_loginManager;
	IDatabase* m_database;
};
