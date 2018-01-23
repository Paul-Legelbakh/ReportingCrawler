using MongoDB.Bson;
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
        public ObjectId CrawlerID { get; set; }
        [BsonElement("status")]
        public string Status { get; set; }
        [BsonElement("search_condition")]
        public string SearchCondition { get; set; }
        [BsonElement("error_message")]
        public string ErrorMessage { get; set; }
        [BsonElement("_class")]
        public string Class { get;set;}
        [BsonElement("created_date")]
        public DateTime CreatedDate { get; set; }
        [BsonElement("modified_date")]
        public DateTime ModifiedDate { get; set; }
    }
}