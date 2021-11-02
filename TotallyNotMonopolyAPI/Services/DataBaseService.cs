using Model;
using MongoDB.Driver;
using Persistence;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DataBaseService
    {
        DataBaseConection dataBase = new DataBaseConection();
        public Ranking GetRanking()
        {
            Ranking ranking = new Ranking();
            List<Ranking> lst = dataBase.DataBaseMongo().Find(d => true).ToList();
            ranking.Name = lst.Find(d => true).Name;
            ranking.RankingNames = lst.Find(d => true).RankingNames;
            ranking.RankingScore = lst.Find(d => true).RankingScore;
            return ranking;
        }
    }
}
