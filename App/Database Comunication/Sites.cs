using System;

namespace DatabaseCommunication
{
    public static class Sites
    {
        private const string beginning = @"http://192.168.1.19/Alternative(2.0)/";

        public static string isUserInDB = beginning + "users/Existance/User.php";
    }
}
