using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportingDataBase.Models
{
    public class crawler
    {
        [BsonId]
        public string _id { get; set; }
        public string status { get; set; }
        public string searchCondition { get; set; }
        public string error_message { get; set; }
        public DateTime created_date { get; set; }
        public DateTime modified_date { get; set; }
    }
}