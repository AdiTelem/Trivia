#pragma once

#include "SqliteDatabase.h"

class SqliteDatabase;

int foundResult(void* data, int argc, char** argv, char** azColName);
int collectQuestionFromDB(void* data, int argc, char** argv, char** azColName);
int collectUsernameFromDB(void* data, int argc, char** argv, char** azColName);
int collectSingleFloat(void* data, int argc, char** argv, char** azColName);
int collectSingleInt(void* data, int argc, char** argv, char** azColName);