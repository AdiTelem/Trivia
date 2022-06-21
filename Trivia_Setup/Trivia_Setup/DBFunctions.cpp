#include "DBFunctions.h"

//if the callback function was called, returns true
//checks if the SELECT command found anything
int foundResult(void* data, int argc, char** argv, char** azColName)
{
	*(bool*)data = true;
	return 0;
}

int collectQuestionFromDB(void* data, int argc, char** argv, char** azColName)
{
	(*(std::vector<QuestionInfo>*)data).push_back({argv[1], argv[2], argv[3], argv[4], argv[5], argv[6] });

	return 0;
}

int collectUsernameFromDB(void* data, int argc, char** argv, char** azColName)
{
	(*(std::vector<string>*)data).push_back({ argv[0] });

	return 0;
}

int collectSingleFloat(void* data, int argc, char** argv, char** azColName)
{
	*(float*)data = std::stof(argv[0]);
	return 0;
}

int collectSingleInt(void* data, int argc, char** argv, char** azColName)
{
	*(int*)data = std::stoi(argv[0]);
	return 0;
}