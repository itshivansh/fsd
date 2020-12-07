using Entity.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
   public class MongoDbContext
    {
        MongoClient client;
        IMongoDatabase database;
        public MongoDbContext()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("ProductDb");
        }
        public IMongoCollection<Product> Products => database.GetCollection<Product>("Products");
    }
}
