#include "LoginManager.h"
LoginManager::LoginManager()
{
}

LoginManager::LoginManager(IDatabase* database):
	m_database(database)
{
}

LoginManager::~LoginManager()
{
	delete m_database;
}

void LoginManager::signup(std::string userName, std::string password, std::string email)
{
	if (m_database->addNewUser(userName, password, email))
	{
		std::cout << "User added successfully" << std::endl;
	}
	else
	{
		std::cout << "User add failed" << std::endl;
		throw(std::exception());
	}
}

void LoginManager::login(std::string userName, std::string password)
{
	if (std::find(m_loggedUsers.begin(), m_loggedUsers.end(), LoggedUser(userName)) == m_loggedUsers.end())
	{
		if (m_database->doesUserExist(userName))
		{
			if (m_database->doesPasswordMatch(userName, password))
			{
				std::cout << "User Login suuccessfully" << std::endl;
				m_loggedUsers.push_back(LoggedUser(userName));
			}
			else
			{
				std::cout << "password doesn't match" << std::endl;
				throw(std::exception());
			}
		}
		else
		{
			std::cout << "User doesn't exist" << std::endl;
			throw(std::exception());
		}
	}
	else
	{
		std::cout << "User already logged in" << std::endl;
		throw(std::exception());
	}
}

void LoginManager::logout(std::string userName)
{
	std::vector<LoggedUser>::iterator it;

	if (m_database->doesUserExist(userName))
	{
		it = find(m_loggedUsers.begin(), m_loggedUsers.end(), LoggedUser(userName));
		if (it == m_loggedUsers.end())
		{
			std::cout << "User isn't logged in" << std::endl;
			throw(std::exception());
		}
		else
		{
			m_loggedUsers.erase(it);
			std::cout << "User logged out successfully" << std::endl;
		}
	}
	else
	{
		std::cout << "User doesn't exists" << std::endl;
		throw(std::exception());
	}
}

IDatabase* LoginManager::getDatabase()
{
	return m_database;
}
