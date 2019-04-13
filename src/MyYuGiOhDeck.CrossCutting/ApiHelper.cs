using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MyYuGiOhDeck.CrossCutting
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; } = new HttpClient();

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://db.ygoprodeck.com/api/v4/cardinfo.php");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
