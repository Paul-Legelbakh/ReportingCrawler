using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportingDataBase.Models
{
    public class Crawler
    {
        [BsonId]
        public string CrawlerID { get; set; }
        [BsonElement("status")]
        public string Status { get; set; }
        [BsonElement("searchCondition")]
        public string SearchCondition { get; set; }
        [BsonElement("error_message")]
        public string ErrorMessage { get; set; }
        [BsonElement("created_date")]
        public DateTime CreatedDate { get; set; }
        [BsonElement("modified_date")]
        public DateTime ModifiedDate { get; set; }
    }
}