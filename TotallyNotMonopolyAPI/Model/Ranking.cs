using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class Ranking
    {
        public string Name { get; set; }

        public string[] RankingNames { get; set; }

        public string[] RankingScore { get; set; }

        public override string ToString()
        {
            string res = "";

            res = "Ranking del " + Name + "\n";
            for (int i = 0; i < RankingNames.Length; i++)
            {
                res += RankingNames.GetValue(i) + ": " + RankingScore.GetValue(i) + "\n";
            }
            return res;
        }
    }    
}
