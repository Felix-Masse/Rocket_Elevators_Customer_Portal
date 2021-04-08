using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace RocketElevator_Customer.Class
{
    public class Rest_Api
    {
        public static HttpClient RestApi { get; set; }

        public static void InitializeClient()
        {
            RestApi = new HttpClient();
            RestApi.BaseAddress = new Uri("https://felixrestapicode.azurewebsites.net/api/");
            RestApi.DefaultRequestHeaders.Accept.Clear();
            RestApi.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appplication/json"));
        }


        public class Rootobject
        {
            public string[] emails { get; set; }
        }


    }
}
