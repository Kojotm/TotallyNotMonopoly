using Model;
using MongoDB.Driver;
using Persistence;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class DataBaseService
    {
        readonly DataBaseConection dataBase = new();
        public Ranking GetRanking()
        {
            Ranking ranking = new();
            List<Ranking> lst = dataBase.DataBaseMongo().Find(d => true).ToList();
            ranking.Name = lst.Find(d => true).Name;
            ranking.RankingNames = lst.Find(d => true).RankingNames;
            ranking.RankingScore = lst.Find(d => true).RankingScore;
            return ranking;
        }
    }
}
