#pragma once

#include <vector>
#include <iostream>
#include <string>

using std::string;

typedef struct
{
	string qText;
	string answer1;
	string answer2;
	string answer3;
	string answer4;
	string correctAnswers;
}QuestionInfo;

class IDatabase
{
public:
	virtual bool doesUserExist(string userName) = 0;
	virtual bool doesPasswordMatch(string userName, string password) = 0;
	virtual bool addNewUser(string userName, string password, string email) = 0;
	virtual std::vector<QuestionInfo> getQuestions(int amount) = 0;
	virtual float getPlayerAverageAnswerTime(string userName) = 0;
	virtual int getNumOfCorrectAnswers(string userName) = 0;
	virtual int getNumOfTotalAnswers(string userName) = 0;
	virtual int getNumOfPlayerGames(string userName) = 0;
	virtual std::vector<string> getUsernames() = 0;
};


