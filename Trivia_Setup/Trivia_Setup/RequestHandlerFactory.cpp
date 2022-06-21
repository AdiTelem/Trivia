#include "RequestHandlerFactory.h"

RequestHandlerFactory::RequestHandlerFactory()
{
}

RequestHandlerFactory::RequestHandlerFactory(IDatabase* database):
	m_database(database), m_loginManager(LoginManager(database)), m_statisticsManager(StatisticsManager(database)),
	m_roomManager(RoomManager())
{
}

RequestHandlerFactory::~RequestHandlerFactory()
{
}

LoginRequestHandler* RequestHandlerFactory::createLoginRequestHandler()
{
	LoginRequestHandler* logReqHand = new LoginRequestHandler(m_loginManager, *this);
	return logReqHand;
}

LoginManager& RequestHandlerFactory::getLoginManager()
{
	return m_loginManager;
}

MenuRequestHandler* RequestHandlerFactory::createMenuRequestHandler(LoggedUser user)
{
	MenuRequestHandler* menuReqHandler = new MenuRequestHandler(user, m_roomManager, m_statisticsManager, m_loginManager, *this);

	return menuReqHandler;
}

RoomManager& RequestHandlerFactory::getRoomManager()
{
	return m_roomManager;
}

StatisticsManager& RequestHandlerFactory::getStatisticsManager()
{
	return m_statisticsManager;
}

RoomAdminRequestHandler* RequestHandlerFactory::createRoomAdminRequestHandler(Room room, LoggedUser user)
{
	return new RoomAdminRequestHandler(user, room, *this, m_roomManager);
}

RoomMemberRequestHandler* RequestHandlerFactory::createRoomMemberRequestHandler(Room room, LoggedUser user)
{
	return new RoomMemberRequestHandler(user, room, *this, m_roomManager);
}
