
#include "StatisticsManager.h"

StatisticsManager::StatisticsManager()
{
}

StatisticsManager::StatisticsManager(IDatabase* m_database):
	m_database(m_database)
{
}

std::vector<string> StatisticsManager::getHighScore()
{
	std::vector<string> users = m_database->getUsernames();
	std::vector<int> scores;
	int tempScore = 0;
	string tempName;
	StatisticsInfo info;

	int i = 0, j = 0, score = 0, scoreAmount = 0;
	
	for (i = 0; i < users.size(); i++)
	{
		info = getPersonalStatistics(users[i]);
		score = MAX_SCORE * (((float)MAX_ANSWER_TIME - info.averageAnswerTime) / MAX_ANSWER_TIME) * ((float)info.correctAnswers / info.totalAnswers);
		if (score <= MAX_SCORE)
		{
			scoreAmount++;
			scores.push_back(MAX_SCORE * (((float)MAX_ANSWER_TIME - info.averageAnswerTime) / MAX_ANSWER_TIME) * ((float)info.correctAnswers / info.totalAnswers));
		}
	}

	for (i = 0; i < scoreAmount; i++)
	{
		for (j = 0; j < scoreAmount; j++)
		{
			if (scores[i] > scores[j])
			{
				tempScore = scores[i];
				tempName = users[i];

				scores[i] = scores[j];
				users[i] = users[j];

				scores[j] = tempScore;
				users[j] = tempName;
			}
		}
	}


	return { users[0] + " - " + std::to_string(scores[0]),
		users[1] + " - " + std::to_string(scores[1]),
		users[2] + " - " + std::to_string(scores[2])};
}

StatisticsInfo StatisticsManager::getPersonalStatistics(string userName)
{
	StatisticsInfo stats =  StatisticsInfo{ m_database->getPlayerAverageAnswerTime(userName), m_database->getNumOfPlayerGames(userName), m_database->getNumOfCorrectAnswers(userName), m_database->getNumOfTotalAnswers(userName) };

	return stats;
}
