using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Client_gui
{
    static class Program
    {
        public const byte LOGIN_CODE = 10;
        public const byte SIGNUP_CODE = 11;
        public const byte SIGNOUT_CODE = 12;
        public const byte GET_ROOMS_CODE = 20;
        public const byte GET_PLAYERS_IN_ROOM_CODE = 21;
        public const byte JOIN_ROOM_CODE = 22;
        public const byte CREATE_ROOM_CODE = 23;
        public const byte GET_PERSONAL_STATS_CODE = 30;
        public const byte GET_HIGH_SCORES_CODE = 31;
        public const byte CLOSE_ROOM_CODE = 40;
        public const byte START_GAME_CODE = 41;
        public const byte GET_ROOM_STATE_CODE = 42;
        public const byte LEAVE_ROOM_CODE = 43;
        public const byte ERROR_CODE = 61;
        public const int OK_STATUS = 100;
        public const int LOGIN_FAILED = 201;
        public const string SIGNUP_FAILED = "202";
        public const byte NO_ROOMS = 251;
        public const string ROOM_DOESNT_EXIST = "301";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MySocket sock = new MySocket();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var start = new Menu();
            start.FormClosed += WindowClosed;
            start.Show();
            Application.Run();
        }


        static void WindowClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) Application.Exit();
            else Application.OpenForms[0].FormClosed += WindowClosed;
        }
    }
}
