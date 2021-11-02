using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Model;

namespace Persistence
{
    public class DataBaseConection 
    {
        public IMongoCollection<Ranking> DataBaseMongo()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb://user:Abcd1234.@cluster0-shard-00-00.dyikt.mongodb.net:27017,cluster0-shard-00-01.dyikt.mongodb.net:27017,cluster0-shard-00-02.dyikt.mongodb.net:27017/ranking?ssl=true&replicaSet=atlas-13ofh9-shard-0&authSource=admin&retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var ranking = client.GetDatabase("ranking");
            var finalranking = ranking.GetCollection<Ranking>("ranking");
            
            return finalranking;
        }
        
    }
}
