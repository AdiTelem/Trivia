#pragma once

#include "IDatabase.h"
#include <iostream>
#include "sqlite3.h"
#include <io.h>
#include <mutex>
#include "DBFunctions.h"

#define DB_NAME "triviaDB.sqlite"

#define DEFAULT_QUESTION_NUMBER 10

class SqliteDatabase : public IDatabase
{
public:
	SqliteDatabase();
	~SqliteDatabase();
	bool doesUserExist(string userName);
	bool doesPasswordMatch(string userName, string password);
	bool addNewUser(string userName, string password, string email);
	std::vector<QuestionInfo> getQuestions(int amount);

private:
	sqlite3* db;
	char* errMessage = nullptr;
	std::string sqlStatement;
	QuestionInfo builtInQuestions[DEFAULT_QUESTION_NUMBER] = { {"Is one greater than two?", "yes", "maybe", "no", "this is the right answer", "1"},
															   {"little chinese boy went to the garden, what garden?", "children garden", "animal garden", "plant garden", "he died on his way there", "3"},
															   {"1 + 1 = ?", "2", "tounge", "42", "53", "24"}, 
															   {"who's the best?", "Itamar", "Adi", "Yehonatan the madrih", "You, the players", "12"},
															   {"what do you prefer", "Pizza", "Hamburger", "Killing inoccent children", "Grape Juice", "4"},
															   {"1 + 2 + 3 + 4 + 123123*123123", "15,159,273,139", "15,159,273,138", "15,159,273,140", "0", "3"},
															   {"6:2(1+2)", "9", "10", "2", "1", "32"},
															   {"two asians walked into a bar, they ordered a drink, what was it?", "none, they are poor", "big choco milk", "20 shots of vodka", "the blood of the inoccent child", "4"},
															   {"BFF is:", "Big F***ing Finger", "Ten Coins in Machine", "Best Friend Forever", "Blue and Fancy Feet", "1"},
															   {"Einstein is the big boy here, what is E?", "mc^2", "Mc'donalds", "Elephants are roaming the city, take cover!", "(speedy) mcqueen", "1"} };
	std::vector<QuestionInfo> currentQuestions;
	std::mutex currentQuestionsLock;
	std::vector<string> currentUsers;
	std::mutex currentUsersLock;
	int res;
	bool open();
	void close();
	void insertFirstQuestions();
	float getPlayerAverageAnswerTime(string userName);
	int getNumOfCorrectAnswers(string userName);
	int getNumOfTotalAnswers(string userName);
	int getNumOfPlayerGames(string userName);
	std::vector<string> getUsernames();
};


