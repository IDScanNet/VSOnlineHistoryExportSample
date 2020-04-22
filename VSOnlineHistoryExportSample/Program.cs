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
            var requestTester = new RequestTester();
            requestTester.RunTest();
        }
    }
    public class RequestTester
    {
        private const string BaseUrl = "https://veriscanonline.com/";//"http://localhost:1456/";
        private HttpClient HttpClient { get; set; }

        private RequestParams Requests { get; set; } = new RequestParams();

        private bool IsJson { get; set; }
        public RequestTester()
        {
            HttpClient = new HttpClient(new HttpClientHandler()
            {
                AllowAutoRedirect = false
            })
            {
                BaseAddress = new Uri(BaseUrl)
            };
        }
        public void RunTest()
        {
            Console.Write("Enter your user name: ");
            var userName = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = GetPassword();
            Console.Write("Json result (y/n)?: ");
            IsJson = Console.ReadLine() == "y";

            Console.Write("Authorization...");

            var authResponse = HttpClient.PostAsync("Authorize",
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

            foreach (var request in Requests.Requests)
            {
                SendRequest(request);
                Console.WriteLine("Press any key for perform next request: ");
                Console.ReadKey();
            }
            Console.WriteLine("Done, press any key for exit");
            Console.ReadKey();
        }
        private void SendRequest(Params request)
        {

            Console.WriteLine($"For request to {request.EndPointUrl} enter next parameters");
            var filters = new Dictionary<string, string>();
            foreach (var filter in request.Filters)
            {

                Console.WriteLine($"Enter parameter: {filter.FieldName}");
                if (filter.Required) { Console.Write(" [!REQUIRED!]"); }
                var userData = Console.ReadLine();
                if (string.IsNullOrEmpty(userData) && filter.Required)
                {
                    Console.WriteLine($"Error: required parameter is not filled. Skipping method {request.EndPointUrl} .....");
                    return;
                }
                var value = !string.IsNullOrEmpty(userData) ? userData : filter.Value;
                filters.Add(filter.FieldName, value.ToString());

            }
            var url = UrlHelper.Url(request.EndPointUrl, filters);
            Console.Write($"Perform request to {request.EndPointUrl} ...");

            if (IsJson)
            {
                HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
            var historyResponse = HttpClient.GetAsync(url).Result;
            var content = historyResponse.Content.ReadAsStringAsync().Result;
            if (!historyResponse.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error: {historyResponse.StatusCode}:{content}");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Success");
            var fileExt = IsJson ? "json" : "xml";
            var path = Path.GetFullPath($"result_{request.EndPointUrl.Replace("/", "")}.{fileExt}");
            File.WriteAllText(path, content);
            Console.WriteLine($"Result saved in a file {path}");
            Console.WriteLine("Open file (y/n): ");
            var isOpen = Console.ReadLine() == "y";
            if (isOpen)
            {
                Process.Start(path);
            }

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
