using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalReportingBD.Models
{
    public class Crawler
    {
        public string _id { get; set; }
        public string status { get; set; }
        public string search_condition { get; set; }
        public string error_message { get; set; }
        public DateTime created_date { get; set; }
        public DateTime modified_date { get; set; }
    }
}
