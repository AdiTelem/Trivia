using System;
using System.Collections.Generic;
using System.Text;

namespace Client_gui
{
    struct StatusResponse
    {
        public int status { get; set; }

        public StatusResponse(int status)
        {
            this.status = status;
        }
    }

    public class RoomData
    {
        public uint id;
        public string name;
        public uint maxPlayers;
        public uint numOfQuestionsinGame;
        public uint timePerQuestion;
        public uint isActive;
        public RoomData(uint id, uint isActive, uint maxPlayers, string name, uint numOfQuestionsinGame, uint timePerQuestion)
        {
            this.id = id;
            this.name = name;
            this.maxPlayers = maxPlayers;
            this.numOfQuestionsinGame = numOfQuestionsinGame;
            this.timePerQuestion= timePerQuestion;
            this.isActive = isActive;
        }
    }

    public class Room
    {
        public RoomData room;

        public Room(RoomData room)
        {
            this.room = room;
        }
    }

    public class GetRoomsResponse
    {
        public int status;
        public List<Room> rooms;

        public GetRoomsResponse(List<Room> rooms, int status)
        {
            this.status = status;
            this.rooms = rooms;
        }
    }

    public class Player
    {
        public string player;

        public Player(string player)
        {
            this.player = player;
        }
    }

    /*
    struct Players
    {
        public List<Player> player;
    }*/

    public class Statistics
    {
        public string stat;

        public Statistics(string stat)
        {
            this.stat = stat;
        }
    }

    public class UserStatistics
    {
        public Statistics stat;

        public UserStatistics(Statistics stat)
        {
            this.stat = stat;
        }
    }

    public class UserStatisticsResponse
    {
        public int status;
        public List<Statistics> UserStatistics; 

        public UserStatisticsResponse(List<Statistics> UserStatistics, int status)
        {
            this.status = status;
            this.UserStatistics = UserStatistics;
        }
    }
}

