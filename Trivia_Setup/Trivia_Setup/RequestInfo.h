#pragma once

#include <ctime>

typedef struct RequestInfo
{
	int id;
	time_t receivalTime;
	char* buffer;


} RequestInfo;