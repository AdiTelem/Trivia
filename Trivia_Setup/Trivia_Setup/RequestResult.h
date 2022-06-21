#pragma once

#include "IRequestHandler.h"
#include <iostream>
#include <vector>


using std::vector;

//RESPONSE CODES
#define SUCCEED_STATUS 100
#define LOGIN_FAILED 201
#define SIGNUP_FAILED 202
#define NO_ROOMS 251
#define ROOM_DOESNT_EXIST 301

class IRequestHandler;
typedef struct
{
	char* response;
	IRequestHandler* newHandler;
	
} RequestResult;



