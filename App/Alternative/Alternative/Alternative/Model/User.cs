using System;
using System.Collections.Generic;
using System.Text;

namespace Alternative.Model
{
    public static class ThisUser
    {
        private static string userID;
        private static string username;

        public static string UserID 
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value; 
            }
        }
        public static string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
    }
}
