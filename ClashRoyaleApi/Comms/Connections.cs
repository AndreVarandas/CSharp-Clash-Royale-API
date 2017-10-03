using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyale
{   
    /// <summary>
    /// Manages http requests
    /// </summary>
    public class Connections
    {
        /// <summary>
        /// Returns a JSON response for the url
        /// </summary>
        /// <param name="url">Url to search for</param>
        /// <returns>JSON</returns>
        public static async Task<string> GetURL(string url)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var result = await httpClient.GetStringAsync(url);
                    return result.ToString();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}
