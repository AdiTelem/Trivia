#include "LoggedUser.h"

LoggedUser::LoggedUser(std::string name):
    m_username(name)
{
}

std::string LoggedUser::getUsername()
{
    return this->m_username;
}

bool LoggedUser::operator==(const LoggedUser& other)
{
    return this->m_username == other.m_username;
}
