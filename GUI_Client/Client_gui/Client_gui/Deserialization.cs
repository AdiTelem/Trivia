using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Client_gui
{
    static class Deserialization
    {
        public static int sendAndGetStatusOfMessage(string jsonMsg, byte Code)
        {
            string response = sendMessageWithCode(jsonMsg, Code);
            response = response[5..].Replace("\0", string.Empty);
            Console.WriteLine(response);
            if (response != "")
            {
                StatusResponse statusResponse = JsonSerializer.Deserialize<StatusResponse>(response);

                return statusResponse.status;
            }

            return Program.ERROR_CODE;
        }

        public static GetRoomsResponse sendAndGetRoomsOfMessage(string jsonMsg, byte Code)
        {
            string response = sendMessageWithCode(jsonMsg, Code);
            response = response[5..].Replace("\0", string.Empty);
            Console.WriteLine(response);

            JavaScriptSerializer ser = new JavaScriptSerializer();

            GetRoomsResponse getRoomResponse = ser.Deserialize<GetRoomsResponse>(response);

            return getRoomResponse;
        }

        public static List<Player> sendAndGetPlayersOfMessage(string jsonMsg, byte Code)
        {
            string response = sendMessageWithCode(jsonMsg, Code);
            response = response[5..].Replace("\0", string.Empty);
            Console.WriteLine(response);

            JavaScriptSerializer ser = new JavaScriptSerializer();

            List<Player> getPlayersResponse = ser.Deserialize<List<Player>>(response);

            return getPlayersResponse;
        }

        public static UserStatisticsResponse sendAndGetStatsOfMessage(string jsonMsg, byte Code)
        {
            string response = sendMessageWithCode(jsonMsg, Code);
            response = response[5..].Replace("\0", string.Empty);
            Console.WriteLine(response);

            JavaScriptSerializer ser = new JavaScriptSerializer();

            UserStatisticsResponse getStatsResponse = ser.Deserialize<UserStatisticsResponse>(response);

            return getStatsResponse;
        }

        public static string sendMessageWithCode(string jsonMsg, byte Code)
        {
            if (jsonMsg != null)
            {
                return Encoding.ASCII.GetString(MySocket.SendRecieve(Encoding.ASCII.GetBytes(jsonMsg), Code));
            }
            else
            {
                return Encoding.ASCII.GetString(MySocket.SendRecieve(null, Code));
            }
            
        }
    }
}
