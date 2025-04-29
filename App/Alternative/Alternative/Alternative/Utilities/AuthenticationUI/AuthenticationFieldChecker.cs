using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Here we will write the base condition for a valid username and password
/// </summary>

namespace Alternative.Utilities.AuthenticationUI
{
    public class AuthenticationFieldChecker
    {
        public static string CheckUsernameFieldSpelling(string usernameField)
        {
            if (usernameField == string.Empty)
            {
                return "Empty imput. Please enter your username or email.";
            }
            else
            {
                return "";
            }
        }

        public static string CheckPasswordFieldSpelling(string passwordField)
        {
            if (passwordField == string.Empty)
            {
                return "Empty imput. Please enter the password.";
            }
            else
            {
                return "";
            }
        }
    }
}
