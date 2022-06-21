#include "JsonRequestPacketDeserializer.h"

LoginRequest Deserializer::deserializeLoginRequest(char* bJson)
{
    std::string json = std::string(bJson);

    LoginRequest loginRequest = { getDataFromJson(json, USERNAME_KEY), getDataFromJson(json, PASSWORD_KEY) };
    std::cout << loginRequest.username << ", " << loginRequest.password << std::endl;

	return loginRequest;
}

SignupRequest Deserializer::deserializeSignupRequest(char* bJson)
{
    std::string json = std::string(bJson);

    SignupRequest signupRequest = { getDataFromJson(json, USERNAME_KEY),
        getDataFromJson(json, PASSWORD_KEY),  getDataFromJson(json, EMAIL_KEY), };

	return signupRequest;
}

GetPlayersInRoomRequest Deserializer::deserializeGetPlayersInRoomRequest(char* bJson)
{
    std::string json = std::string(bJson);

    GetPlayersInRoomRequest getPlayersInRoomRequest = {  std::stoi(getDataFromJson(json, ROOMID_KEY))};

    return getPlayersInRoomRequest;
}

JoinRoomRequest Deserializer::deserializeJoinRoomRequest(char* bJson)
{
    std::string json = std::string(bJson);

    JoinRoomRequest joinRoomRequestRequest = { std::stoi(getDataFromJson(json, ROOMID_KEY)) };

    return joinRoomRequestRequest;
}

CreateRoomRequest Deserializer::deserializeCreateRoomRequest(char* bJson)
{
    std::string json = std::string(bJson);
    
    CreateRoomRequest createRoomRequestRequest = { getDataFromJson(json, ROOMNAME_KEY), 
        std::stoul(getDataFromJson(json, MAXUSERS_KEY)), std::stoul(getDataFromJson(json, QUESTIONCOUNT_KEY)), std::stoul(getDataFromJson(json, ANSWERTIMEOUT_KEY)) };

    return createRoomRequestRequest;
}

std::string Deserializer::getJsonFromRequest(char* request)
{
    int size = 0;
    memcpy(&size, request + CODE_SIZE, SIZE_SIZE);
    char* json = new char[size];
    memcpy(json, request + CODE_SIZE + SIZE_SIZE, size);
    json[size] = 0;

    return std::string(json);
}

std::string Deserializer::getDataFromJson(std::string json, std::string key)
{
    int loc = json.find(key);
    int start_loc = loc + key.size();
    int end_loc = json.find(",", start_loc);
    if (end_loc == std::string::npos)
    {
        end_loc = json.find("}", start_loc);
    }

    return json.substr(start_loc+1, end_loc - start_loc-2);
}
