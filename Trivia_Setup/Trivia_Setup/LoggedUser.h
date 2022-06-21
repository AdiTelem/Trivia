#pragma once

#include <iostream>
#include <string>

using std::string;

class LoggedUser
{
public:
	LoggedUser(std::string name);
	std::string getUsername();
	bool operator==(const LoggedUser& other);

private:
	string m_username;
};
