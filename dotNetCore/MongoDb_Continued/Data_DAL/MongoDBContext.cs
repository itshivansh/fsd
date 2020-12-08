using Entities.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;


namespace DataDAL.Repository
{
    public class MongoDBContext
    {
        MongoClient client;
        IMongoDatabase database;
        public MongoDBContext(IConfiguration configuration)
        {
            
            client = new MongoClient(configuration.GetSection("MongoDB:server").Value);

            database = client.GetDatabase(configuration.GetSection("MongoDB:db").Value);
        }
        public IMongoCollection<Product> Products => database.GetCollection<Product>("Products");
    }
}
