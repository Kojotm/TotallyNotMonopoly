using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model;
using Model.Cards;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Persistence
{
    public class GameTableContext : DbContext
    {
        private readonly IConfiguration _config;

        public GameTableContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public DbSet<Field> Fields { get; set; }
        public DbSet<Chance> ChanceCards { get; set; }
        public DbSet<Fortune> FortuneCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("TotallyNotMonopoly"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Field>().ToTable("TableCards");

            List<Field> cardsList;
            using StreamReader r = new StreamReader(@"..\Model\Assets\Fields\Property.json");
            string json = r.ReadToEnd();
            cardsList = JsonConvert.DeserializeObject<List<Field>>(json);

            foreach (var item in cardsList)
            {
                modelBuilder.Entity<Field>().HasData(new
                {
                    item.Id,
                    item.Name,
                    item.Description,
                    item.Color,
                    item.Image,
                    item.Rent,
                    item.Value,
                    item.Level,
                    item.UpgradeCost,
                    item.Col,
                    item.Row,
                    item.Type,
                    item.SetNumber
                });
            }

            modelBuilder.Entity<Chance>().ToTable("ChanceCards");

            List<Chance> chanceCardsList;
            using StreamReader chanceReader = new StreamReader(@"..\Model\Assets\Chance\ChanceCards.json");
            string chanceJson = chanceReader.ReadToEnd();
            chanceCardsList = JsonConvert.DeserializeObject<List<Chance>>(chanceJson);

            for(int i = 0; i < chanceCardsList.Count; i++)
            {
                modelBuilder.Entity<Chance>().HasData(new
                {
                    chanceCardsList[i].Id,
                    chanceCardsList[i].Description,
                    chanceCardsList[i].Type,
                    chanceCardsList[i].Amount
                });
            }

            modelBuilder.Entity<Fortune>().ToTable("FortuneCards");

            List<Fortune> fortuneCardsList;
            using StreamReader fortuneReader = new StreamReader(@"..\Model\Assets\Fortune\FortuneCards.json");
            string fortuneJson = fortuneReader.ReadToEnd();
            fortuneCardsList = JsonConvert.DeserializeObject<List<Fortune>>(fortuneJson);

            for (int i = 0; i < fortuneCardsList.Count; i++)
            {
                modelBuilder.Entity<Fortune>().HasData(new
                {
                    fortuneCardsList[i].Id,
                    fortuneCardsList[i].Description,
                    fortuneCardsList[i].Type,
                    fortuneCardsList[i].Amount
                });
            }
        }
    }
}
