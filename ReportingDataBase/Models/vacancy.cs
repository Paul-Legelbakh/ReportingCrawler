using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportingDataBase.Models
{
    public class vacancy
    {
        [BsonId]
        public string _id { get; set; }
        public string crawler_id { get; set; }
        public string link { get; set; }
        public string title { get; set; }
        public string raw { get; set; }
        public string status { get; set; }
        public DateTime created_date { get; set; }
        public DateTime modified_date { get; set; }
    }
}