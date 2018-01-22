using MongoDB.Bson;
using MongoDB.Driver;
using ReportingDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportingDataBase.Context
{
    public class MongoDBContext
    {
        MongoClient mongoClient = new MongoClient("mongodb://192.168.128.231:27017");

        public MongoDBContext()
        {

        }


        public List<Crawler> GetCrawlers()
        {
            var db = mongoClient.GetDatabase("crawler");
            var crawlers = db.GetCollection<Crawler>("crawler");
            return crawlers.Find(new BsonDocument()).ToList();
        }

        public List<Vacancy> GetVacancies()
        {
            var db = mongoClient.GetDatabase("crawler");
            var vacancies = db.GetCollection<Vacancy>("vacancy");
            return vacancies.Find(new BsonDocument()).ToList();
        }
    }
}