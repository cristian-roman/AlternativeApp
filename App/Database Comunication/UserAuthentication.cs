using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommunication
{
    public static class UserAuthentication
    {
        public static async Task<bool> IsUserInDB(string identifier, string password)
        {
            Dictionary<string, string> nvc = new Dictionary<string, string>(2);

            nvc.Add("Identifier", identifier);
            nvc.Add("Password", password);

            string response = await SiteAnswer.GetAnswer(nvc, Sites.isUserInDB);

            if (response == "false")
            {
                return false;
            }
            else if (response == "true")
            {
                return true;
            }
            else
            {
                throw new Exception("The site could not be reached.");
            }
        }
    }
}
