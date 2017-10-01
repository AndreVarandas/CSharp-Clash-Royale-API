using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleApi
{
    public class Connections
    {
        public static async Task<string> GetURL(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync(url); // json
                return json;
            }
        }
    }
}
