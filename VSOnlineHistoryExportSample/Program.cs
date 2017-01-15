using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace VSOnlineHistoryExportSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your user name: ");
            var userName = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = GetPassword();
            Console.Write("Json result (y/n)?: ");
            var isJson = Console.ReadLine() == "y";
            var httpClient = new HttpClient(new HttpClientHandler()
            {
                AllowAutoRedirect = false
            })
            {
                BaseAddress = new Uri(" https://veriscanonline.com/")
            };
            Console.Write("Authorization...");

            var authResponse = httpClient.PostAsync("Authorize",
                   new FormUrlEncodedContent(new List<KeyValuePair<string, string>>()
                   {
                        new KeyValuePair<string, string>("UserName", userName),
                        new KeyValuePair<string, string>("Password", password)                   
                   })).Result;
            if (!authResponse.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error: {authResponse.StatusCode}:{authResponse.Content.ReadAsStringAsync().Result}");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Success");
            var url = UrlHelper.Url("Export/History", new
            {
                From = DateTime.UtcNow.AddMonths(-1).ToString("O"),
                To = DateTime.UtcNow.ToString("O"),
                Skip = 0,
                Take = 1000
            });
            Console.Write($"Request history to {url} ...");

            if (isJson)
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }

            var historyResponse = httpClient.GetAsync(url).Result;
            var content = historyResponse.Content.ReadAsStringAsync().Result;
            if (!historyResponse.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error: {historyResponse.StatusCode}:{content}");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Success");
            var fileExt = isJson ? "json" : "xml";
            var path = Path.GetFullPath($"result.{fileExt}");
            File.WriteAllText(path, content);
            Console.WriteLine($"Result saved in a file {path}");
            Console.WriteLine("Open file (y/n): ");
            var isOpen = Console.ReadLine() == "y";
            if (isOpen)
            {
                Process.Start(path);
            }
            Console.WriteLine("Press any key for exit");
            Console.ReadKey();
        }

        private static string GetPassword()
        {
            string pass = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            // Stops Receving Keys Once Enter is Pressed
            while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return pass;
        }
    }
}
