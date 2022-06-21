#pragma once

#include <vector>
#include "LoggedUser.h"
#include "SqliteDatabase.h"
#include "IRequestHandler.h"


class LoginManager
{
private:
	std::vector<LoggedUser> m_loggedUsers;
	IDatabase* m_database;

public:
	LoginManager();
	LoginManager(IDatabase* database);
	~LoginManager();
	void signup(std::string userName, std::string password, std::string email);
	void login(std::string userName, std::string password);
	void logout(std::string userName);
	IDatabase* getDatabase();
};

