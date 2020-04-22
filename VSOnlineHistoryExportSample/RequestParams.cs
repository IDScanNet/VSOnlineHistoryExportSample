using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSOnlineHistoryExportSample
{
    public class RequestParams
    {
        public List<Params> Requests { get; set; }

        public RequestParams()
        {
            Requests = new List<Params>()
            {
                new Params()
                {
                    EndPointUrl = "Export/History",
                    filters = new
                    {
                        From = DateTime.UtcNow.AddMonths(-1).ToString("O"),
                        To = DateTime.UtcNow.ToString("O"),
                        Skip = 0,
                        Take = 1000
                    },
                },
                new Params()
                {
                    EndPointUrl = "Export/SurveysList",
                    filters = new
                    {
                        Active = true
                    }
                },
                new Params()
                {
                    EndPointUrl = "Export/Survey",
                    filters = new
                    {
                        Surveyid = 1,
                        From = DateTime.UtcNow.AddMonths(-1).ToString("O"),
                        To = DateTime.UtcNow.ToString("O"),
                        Skip = 0,
                        Take = 1000
                    }
                },
                new Params()
                {
                    EndPointUrl = "Export/HistoryLogResponses",
                    filters = new
                    {
                        HistoryId=33854071
                    }
                }
            };
        }
    }

    public class Params
    {
        public string EndPointUrl { get; set; }
        public object filters { get; set; }
    }

}
