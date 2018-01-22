using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportingDataBase.Models
{
    public class Vacancy
    {
        [BsonId]
        public string VacancyID { get; set; }
        [BsonElement("crawler_id")]
        public string CrawlerID { get; set; }
        [BsonElement("link")]
        public string Link { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("raw")]
        public string Raw { get; set; }
        [BsonElement("status")]
        public string Status { get; set; }
        [BsonElement("created_date")]
        public DateTime CreatedDate { get; set; }
        [BsonElement("modified_date")]
        public DateTime ModifiedDate { get; set; }
    }
}