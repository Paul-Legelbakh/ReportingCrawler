using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalReportingBD.Models
{
    public class Reporting
    {
        public string CrawlerId { get; set; }
        public string[] VacancyId { get; set; }
        public string[] ParsedVacancyId { get; set; }
    }
}
