using System.Collections.Generic;
using System.Linq;

namespace VSOnlineHistoryExportSample
{
    public class UrlHelper
    {
        public static string Url(string url, Dictionary<string,string> filters)
        {
            if (filters != null)
            {
               if (!url.Contains("?"))
               {
                   url += "?";
               }
               else
               {
                   url += "&";
               }
               url += string.Join("&", filters.Select(x => $"{x.Key}={x.Value}"));
            }
            return url;
        }
    }
}