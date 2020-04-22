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
                    Filters = new List<Filter>()
                    {
                        new Filter { FieldName = "From", Value = DateTime.UtcNow.AddMonths(-1).ToString("O")},
                        new Filter { FieldName = "To", Value = DateTime.UtcNow.ToString("O")},
                        new Filter { FieldName = "Skip", Value = 0},
                        new Filter { FieldName = "Take", Value = 1000}
                    }
                },
                new Params()
                {
                    EndPointUrl = "Export/SurveysList",
                    Filters = new List<Filter>()
                    {
                        new Filter { FieldName = "Active", Value = true},
                    }
                },
                new Params()
                {
                    EndPointUrl = "Export/Survey",
                    Filters = new List<Filter>()
                    {
                        new Filter { FieldName = "Surveyid", Value = new int(), Required = true},
                        new Filter { FieldName = "From", Value = DateTime.UtcNow.AddMonths(-1).ToString("O")},
                        new Filter { FieldName = "Skip", Value = 0},
                        new Filter { FieldName = "Take", Value = 1000}
                    }
                },
                new Params()
                {
                    EndPointUrl = "Export/HistoryLogResponses",
                    Filters = new List<Filter>()
                    {
                        new Filter { FieldName = "Historyid", Value = new int(), Required = true},
                    }
                }
            };
        }
    }

    public class Params
    {
        public string EndPointUrl { get; set; }
        public List<Filter> Filters { get; set; }
    }

    public class Filter
    {
        public string FieldName { get; set; }
        public dynamic Value { get; set; }
        public bool Required { get; set; } = false;
    }

}
