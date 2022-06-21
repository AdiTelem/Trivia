#include "SqliteDatabase.h"

SqliteDatabase::SqliteDatabase()
{
	open();
}

SqliteDatabase::~SqliteDatabase()
{
	close();
}

bool SqliteDatabase::doesUserExist(string userName)
{
	bool callbackCalled = false;

	sqlStatement = "SELECT * FROM users WHERE userName=\"" + userName + "\";";
	res = sqlite3_exec(db, sqlStatement.c_str(), foundResult, &callbackCalled, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << "Failed to look for user " << errMessage << std::endl;
	}

	return callbackCalled;
	
}

bool SqliteDatabase::doesPasswordMatch(string userName, string password)
{
	bool callbackCalled = false;

	sqlStatement = "SELECT * FROM users WHERE userName=\"" + userName + "\" AND password=\"" + password + "\";";
	res = sqlite3_exec(db, sqlStatement.c_str(), foundResult, &callbackCalled, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << "Failed to match password " << errMessage << std::endl;
	}

	return callbackCalled;
}

bool SqliteDatabase::addNewUser(string userName, string password, string email)
{
	sqlStatement = "INSERT INTO users(userName, email, password) VALUES (\"" + userName + "\", \"" + email + "\", \"" + password + "\");";
	res = sqlite3_exec(db, sqlStatement.c_str(), NULL, NULL, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << "Failed to create user " << errMessage << std::endl;
	}

	return !(bool)res;
}

std::vector<QuestionInfo> SqliteDatabase::getQuestions(int amount)
{
	currentQuestionsLock.lock();
	currentQuestions.clear();

	sqlStatement = "SELECT * FROM questions ORDER BY RANDOM() LIMIT " + std::to_string(amount) + ";";
	res = sqlite3_exec(db, sqlStatement.c_str(), collectQuestionFromDB, &currentQuestions, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << "Failed to get questions " << errMessage << std::endl;
	}

	currentQuestionsLock.unlock();
	return currentQuestions;
}

bool SqliteDatabase::open()
{
	int doesFileExist = _access(DB_NAME, 0);
	int res = sqlite3_open(DB_NAME, &db);
	if (res != SQLITE_OK)
	{
		db = nullptr;
		std::cout << "Failed to open DB" << errMessage << std::endl;
		return false;
	}
	if (doesFileExist != 0)
	{
		sqlStatement = "CREATE TABLE IF NOT EXISTS users(id INTEGER PRIMARY KEY, userName TEXT UNIQUE, email TEXT, password TEXT);";
		res = sqlite3_exec(db, sqlStatement.c_str(), NULL, NULL, &errMessage);
		if (res != SQLITE_OK)
		{
			std::cout << "Failed to open DB " << errMessage << errMessage << std::endl;
			if (std::remove(DB_NAME) != 0)
			{
				std::cout << "Failed to delete the database";
			}
			return false;
		}

		sqlStatement = "CREATE TABLE IF NOT EXISTS questions(id INTEGER PRIMARY KEY AUTOINCREMENT, qText TEXT, answer1 TEXT, answer2 TEXT, answer3 TEXT, answer4 TEXT, correctAnswers TEXT);";
		res = sqlite3_exec(db, sqlStatement.c_str(), NULL, NULL, &errMessage);
		if (res != SQLITE_OK)
		{
			std::cout << "Failed to open DB " << errMessage << errMessage << std::endl;
			if (std::remove(DB_NAME) != 0)
			{
				std::cout << "Failed to delete the database";
			}
			return false;
		}
		insertFirstQuestions();

		sqlStatement = "CREATE TABLE IF NOT EXISTS statistics(id INTEGER PRIMARY KEY AUTOINCREMENT, playerID INTERGER, AverageAnswerTime FLOAT, NumOfCorrectAnswers INTEGER, NumOfAnswers INTEGER, PlayerNumOfGames INTEGER, FOREIGN KEY (playerID) REFERENCES users(id));";
		res = sqlite3_exec(db, sqlStatement.c_str(), NULL, NULL, &errMessage);
		if (res != SQLITE_OK)
		{
			std::cout << "Failed to open DB " << errMessage << errMessage << std::endl;
			if (std::remove(DB_NAME) != 0)
			{
				std::cout << "Failed to delete the database";
			}
			return false;
		}
	}

	return true;
}

void SqliteDatabase::insertFirstQuestions()
{
	int i = 0;
	for (i = 0; i < DEFAULT_QUESTION_NUMBER; i++)
	{
		sqlStatement = "INSERT INTO questions(qText, answer1, answer2, answer3, answer4, correctAnswers) VALUES (\"" + 
			builtInQuestions[i].qText + "\", \"" + builtInQuestions[i].answer1 + "\", \"" + builtInQuestions[i].answer2 +
			"\" , \"" + builtInQuestions[i].answer3 + "\", \"" + builtInQuestions[i].answer4 + "\", \"" + builtInQuestions[i].correctAnswers + "\");";
		res = sqlite3_exec(db, sqlStatement.c_str(), NULL, NULL, &errMessage);
		if (res != SQLITE_OK)
		{
			std::cout << "Failed to create question " << errMessage << std::endl;
		}
	}
}

float SqliteDatabase::getPlayerAverageAnswerTime(string userName)
{
	float answer = -1;
	sqlStatement = "SELECT (AverageAnswerTime) FROM statistics WHERE playerID = (SELECT (id) FROM users WHERE userName = \"" + userName + "\");";
	res = sqlite3_exec(db, sqlStatement.c_str(), collectSingleFloat, &answer, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << "Failed to get getPlayerAverageAnswerTime " << errMessage << std::endl;
	}

	return answer;
}

int SqliteDatabase::getNumOfCorrectAnswers(string userName)
{
	int answer = -1;
	sqlStatement = "SELECT (NumOfCorrectAnswers) FROM statistics WHERE playerID = (SELECT (id) FROM users WHERE userName = \"" + userName + "\");";
	res = sqlite3_exec(db, sqlStatement.c_str(), collectSingleInt, &answer, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << "Failed to get getNumOfCorrectAnswers " << errMessage << std::endl;
	}

	return answer;
}

int SqliteDatabase::getNumOfTotalAnswers(string userName)
{
	int answer = -1;
	sqlStatement = "SELECT (NumOfAnswers) FROM statistics WHERE playerID = (SELECT (id) FROM users WHERE userName = \"" + userName + "\");";
	res = sqlite3_exec(db, sqlStatement.c_str(), collectSingleInt, &answer, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << "Failed to get getNumOfTotalAnswers " << errMessage << std::endl;
	}

	return answer;
}

int SqliteDatabase::getNumOfPlayerGames(string userName)
{
	int answer = -1;
	sqlStatement = "SELECT (playerNumOfGames) FROM statistics WHERE playerID = (SELECT (id) FROM users WHERE userName = \"" + userName + "\");";
	res = sqlite3_exec(db, sqlStatement.c_str(), collectSingleInt, &answer, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << "Failed to get getNumOfPlayerGames " << errMessage << std::endl;
	}

	return answer;
}

std::vector<string> SqliteDatabase::getUsernames()
{

	currentUsersLock.lock();
	currentUsers.clear();

	sqlStatement = "SELECT (userName) FROM users;";
	res = sqlite3_exec(db, sqlStatement.c_str(), collectUsernameFromDB, &currentUsers, &errMessage);
	if (res != SQLITE_OK)
	{
		std::cout << "Failed to get users " << errMessage << std::endl;
	}

	currentUsersLock.unlock();
	return currentUsers;
}

void SqliteDatabase::close()
{
	sqlite3_close(db);
	db = nullptr;
}
