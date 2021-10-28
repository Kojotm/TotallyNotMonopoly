using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model.Cards;
using Newtonsoft.Json;
using System.Collections.Generic;
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

        public DbSet<Field> Cards { get; set; }

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
        }
    }
}
