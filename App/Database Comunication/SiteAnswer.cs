using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommunication
{
    class SiteAnswer
    {
        public static async Task<string> GetAnswer(Dictionary<string,string> nvc, string site)
        {
            HttpClient client = new HttpClient();

            var content = new FormUrlEncodedContent(nvc);
            var response = await client.PostAsync(site, content);

            var responseAsString = await response.Content.ReadAsStringAsync();

            return responseAsString;
        }

        ///webServices for images
    }
}
