using System;
using System.Net.Http;

namespace StarDev.Services
{
    public class ServiceBase
    {

        protected const string BaseAddress = "https://web01.star-dev.com";

        protected readonly HttpClient Client;

        protected ServiceBase()
        {
            Client = new HttpClient(new HttpClientHandler());
        }
    }
}
