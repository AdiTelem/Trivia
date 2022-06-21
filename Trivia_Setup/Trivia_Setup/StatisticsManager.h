#pragma once

#include "SqliteDatabase.h"
#include "IRequestHandler.h"
#include <vector>

#define MAX_SCORE 1000
#define MAX_ANSWER_TIME 30

typedef struct
{
	float averageAnswerTime;
	int gamesAmount;
	int correctAnswers;
	int totalAnswers;
}StatisticsInfo;

class StatisticsManager
{
public:
	StatisticsManager();
	StatisticsManager(IDatabase* m_database);
	std::vector<string> getHighScore();
	StatisticsInfo getPersonalStatistics(string userName);

private:
	IDatabase* m_database;
};
