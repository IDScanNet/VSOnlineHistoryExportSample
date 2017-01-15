using System.Linq;

namespace VSOnlineHistoryExportSample
{
    public class UrlHelper
    {
        public static string Url(string url, object parametrs)
        {
            if (parametrs != null)
            {
                var paramDictionary = parametrs.ToDictionary();
                if (!url.Contains("?"))
                {
                    url += "?";
                }
                else
                {
                    url += "&";
                }
                url += string.Join("&", paramDictionary.Select(x => $"{x.Key}={x.Value}"));
            }
            return url;
        }
    }
}