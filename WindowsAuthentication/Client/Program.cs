using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new HttpClientHandler()
            {
                UseDefaultCredentials = true
            };

            var client = new HttpClient(handler)
            {
                BaseAddress = new Uri("https://localhost:44303/api/")
            };

            var response = client.GetAsync("identity").Result;

            response.EnsureSuccessStatusCode();

            var content = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine(content);
            Console.ReadKey();
        }
    }
}
