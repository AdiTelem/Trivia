using System;
using System.Collections.Generic;
using System.Text;

namespace Client_gui
{
	struct LoginRequest
	{
        public string username { get; set; }
        public string password { get; set; }
        public LoginRequest(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }

	struct SignupRequest
	{
		public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public SignupRequest(string username, string password, string email)
        {
            this.username = username;
            this.password = password;
            this.email = email;
        }
    }
    struct GetPlayersInRoomRequest
	{
		public string roomId { get; set; }
        public GetPlayersInRoomRequest(string roomId)
        {
            this.roomId = roomId;
        }
    }
    struct JoinRoomRequest
	{
        public string roomId { get; set; }

        public JoinRoomRequest(string roomId)
        {
            this.roomId = roomId;
        }
    }
    struct GetPlayersRequest
    {
        public string roomId { get; set; }

        public GetPlayersRequest(string roomId)
        {
            this.roomId = roomId;
        }
    }
    struct CreateRoomRequest
	{
		public string roomName { get; set; }
        public string maxUsers { get; set; }
        public string questionCount { get; set; }
        public string answerTimeOut { get; set; }

        public CreateRoomRequest(string roomName, string maxUsers, string questionCount, string answerTimeOut)
        {
            this.roomName = roomName;
            this.maxUsers = maxUsers;
            this.questionCount = questionCount;
            this.answerTimeOut = answerTimeOut;
        }
    }
}
