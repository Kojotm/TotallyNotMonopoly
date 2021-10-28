using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model.Cards;

namespace Persistence
{
    public class GameTableContext : DbContext
    {
        private readonly IConfiguration _config;

        public GameTableContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public DbSet<Card> Cards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("TotallyNotMonopoly"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().ToTable("TableCards");

            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 1,
                Name = "Go",
                Description = "This is the start point.",
                Color = Colors.None,
                Image = "url('../../assets/start-tile.png')",
                Rent = "",
                Value = 200,
                Level = 0,
                UpgradeCost = 0,
                Col = 2,
                Row = 2,
                Type = Types.Corner,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 2,
                Name = "Szertár",
                Description = "A famous bar amoung students not far from the university campus.",
                Color = Colors.Brown,
                Image = "",
                Rent = "2,10,30,90,160,250",
                Value = 60,
                Level = 0,
                UpgradeCost = 50,
                Col = 2,
                Row = 1,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 3,
                Name = "Community Chest",
                Description = "Community Chest.",
                Color = Colors.None,
                Image = "",
                Rent = "",
                Value = 0,
                Level = 0,
                UpgradeCost = 0,
                Col = 2,
                Row = 1,
                Type = Types.CommunityChest,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 4,
                Name = "Bak Egér Borozó",
                Description = "A jug of Arany Ászok is only 330 HUF.",
                Color = Colors.Brown,
                Image = "",
                Rent = "4,20,60,180,320,450",
                Value = 60,
                Level = 0,
                UpgradeCost = 50,
                Col = 2,
                Row = 1,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 5,
                Name = "Income Tax",
                Description = "You were hangover during your exam. Pay your resit cost.",
                Color = Colors.None,
                Image = "",
                Rent = "100",
                Value = 0,
                Level = 0,
                UpgradeCost = 0,
                Col = 2,
                Row = 1,
                Type = Types.Penalty,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 6,
                Name = "Tram 4-6",
                Description = ".",
                Color = Colors.None,
                Image = "",
                Rent = "25,50,100,200",
                Value = 200,
                Level = 0,
                UpgradeCost = 0,
                Col = 2,
                Row = 1,
                Type = Types.Transport,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 7,
                Name = "",
                Description = ".",
                Color = Colors.LightBlue,
                Image = "",
                Rent = "6,30,90,270,400,550",
                Value = 100,
                Level = 0,
                UpgradeCost = 50,
                Col = 2,
                Row = 1,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 8,
                Name = "Chance",
                Description = ".",
                Color = Colors.None,
                Image = "",
                Rent = "",
                Value = 0,
                Level = 0,
                UpgradeCost = 0,
                Col = 2,
                Row = 1,
                Type = Types.Chance,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 9,
                Name = "",
                Description = ".",
                Color = Colors.LightBlue,
                Image = "",
                Rent = "6,30,90,270,400,550",
                Value = 100,
                Level = 0,
                UpgradeCost = 50,
                Col = 2,
                Row = 1,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 10,
                Name = "",
                Description = ".",
                Color = Colors.LightBlue,
                Image = "",
                Rent = "8,40,100,300,450,600",
                Value = 120,
                Level = 0,
                UpgradeCost = 50,
                Col = 2,
                Row = 1,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 11,
                Name = "Jail",
                Description = "This is the jail.",
                Color = Colors.None,
                Image = "url('../../assets/jail-tile.png')",
                Rent = "",
                Value = 50,
                Level = 0,
                UpgradeCost = 0,
                Col = 2,
                Row = 2,
                Type = Types.Corner,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 12,
                Name = "",
                Description = ".",
                Color = Colors.Magenta,
                Image = "",
                Rent = "10,50,150,450,625,750",
                Value = 140,
                Level = 0,
                UpgradeCost = 100,
                Col = 1,
                Row = 2,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 13,
                Name = "Electric Company",
                Description = ".",
                Color = Colors.None,
                Image = "",
                Rent = "4,10",
                Value = 150,
                Level = 0,
                UpgradeCost = 0,
                Col = 1,
                Row = 2,
                Type = Types.Utility,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 14,
                Name = "",
                Description = ".",
                Color = Colors.Magenta,
                Image = "",
                Rent = "10,50,150,450,625,750",
                Value = 140,
                Level = 0,
                UpgradeCost = 100,
                Col = 1,
                Row = 2,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 15,
                Name = "",
                Description = ".",
                Color = Colors.Magenta,
                Image = "",
                Rent = "12,60,180,500,700,900",
                Value = 160,
                Level = 0,
                UpgradeCost = 100,
                Col = 1,
                Row = 2,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 16,
                Name = "Tram 1",
                Description = ".",
                Color = Colors.None,
                Image = "",
                Rent = "25,50,100,200",
                Value = 200,
                Level = 0,
                UpgradeCost = 0,
                Col = 1,
                Row = 2,
                Type = Types.Transport,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 17,
                Name = "",
                Description = ".",
                Color = Colors.Orange,
                Image = "",
                Rent = "14,70,200,550,700,900",
                Value = 180,
                Level = 0,
                UpgradeCost = 100,
                Col = 1,
                Row = 2,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 18,
                Name = "Community Chest",
                Description = "Community Chest.",
                Color = Colors.None,
                Image = "",
                Rent = "",
                Value = 0,
                Level = 0,
                UpgradeCost = 0,
                Col = 1,
                Row = 2,
                Type = Types.CommunityChest,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 19,
                Name = "",
                Description = ".",
                Color = Colors.Orange,
                Image = "",
                Rent = "14,70,200,550,700,900",
                Value = 180,
                Level = 0,
                UpgradeCost = 100,
                Col = 1,
                Row = 2,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 20,
                Name = "",
                Description = ".",
                Color = Colors.Orange,
                Image = "",
                Rent = "16,80,220,600,800,1000",
                Value = 200,
                Level = 0,
                UpgradeCost = 100,
                Col = 1,
                Row = 2,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 21,
                Name = "Offered exam grade",
                Description = "It's your lucky day, you don't have to take the exam.",
                Color = Colors.None,
                Image = "url('../../assets/parking-tile.png')",
                Rent = "",
                Value = 0,
                Level = 0,
                UpgradeCost = 0,
                Col = 2,
                Row = 2,
                Type = Types.Corner,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 22,
                Name = "",
                Description = ".",
                Color = Colors.Red,
                Image = "",
                Rent = "18,90,250,700,875,1050",
                Value = 220,
                Level = 0,
                UpgradeCost = 150,
                Col = 2,
                Row = 1,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 23,
                Name = "Chance",
                Description = ".",
                Color = Colors.None,
                Image = "",
                Rent = "",
                Value = 0,
                Level = 0,
                UpgradeCost = 0,
                Col = 2,
                Row = 1,
                Type = Types.Chance,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 24,
                Name = "",
                Description = ".",
                Color = Colors.Red,
                Image = "",
                Rent = "18,90,250,700,875,1050",
                Value = 220,
                Level = 0,
                UpgradeCost = 150,
                Col = 2,
                Row = 1,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 25,
                Name = "",
                Description = ".",
                Color = Colors.Red,
                Image = "",
                Rent = "20,100,300,750,925,1100",
                Value = 240,
                Level = 0,
                UpgradeCost = 150,
                Col = 2,
                Row = 1,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 26,
                Name = "Tram 2",
                Description = ".",
                Color = Colors.None,
                Image = "",
                Rent = "25,50,100,200",
                Value = 200,
                Level = 0,
                UpgradeCost = 0,
                Col = 2,
                Row = 1,
                Type = Types.Transport,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 27,
                Name = "",
                Description = ".",
                Color = Colors.Yellow,
                Image = "",
                Rent = "22,110,330,800,975,1150",
                Value = 260,
                Level = 0,
                UpgradeCost = 150,
                Col = 2,
                Row = 1,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 28,
                Name = "",
                Description = ".",
                Color = Colors.Yellow,
                Image = "",
                Rent = "22,110,330,800,975,1150",
                Value = 260,
                Level = 0,
                UpgradeCost = 150,
                Col = 2,
                Row = 1,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 29,
                Name = "Water works",
                Description = ".",
                Color = Colors.None,
                Image = "",
                Rent = "4,10",
                Value = 150,
                Level = 0,
                UpgradeCost = 0,
                Col = 1,
                Row = 2,
                Type = Types.Utility,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 30,
                Name = "",
                Description = ".",
                Color = Colors.Yellow,
                Image = "",
                Rent = "24,120,360,850,1025,1200",
                Value = 280,
                Level = 0,
                UpgradeCost = 150,
                Col = 2,
                Row = 1,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 31,
                Name = "Go to your re-examination",
                Description = "It's NOT your lucky day, you have to resit your last exam.",
                Color = Colors.None,
                Image = "url('../../assets/go-to-jail-tile.png')",
                Rent = "",
                Value = 0,
                Level = 0,
                UpgradeCost = 0,
                Col = 2,
                Row = 2,
                Type = Types.Corner,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 32,
                Name = "",
                Description = ".",
                Color = Colors.Green,
                Image = "",
                Rent = "26,130,390,900,1100,1275",
                Value = 300,
                Level = 0,
                UpgradeCost = 200,
                Col = 1,
                Row = 2,
                Type = Types.Property,
                SetNumber = 1
            }); 
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 33,
                Name = "",
                Description = ".",
                Color = Colors.Green,
                Image = "",
                Rent = "26,130,390,900,1100,1275",
                Value = 300,
                Level = 0,
                UpgradeCost = 200,
                Col = 1,
                Row = 2,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 34,
                Name = "Community Chest",
                Description = "Community Chest.",
                Color = Colors.None,
                Image = "",
                Rent = "",
                Value = 0,
                Level = 0,
                UpgradeCost = 0,
                Col = 1,
                Row = 2,
                Type = Types.CommunityChest,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 35,
                Name = "",
                Description = ".",
                Color = Colors.Green,
                Image = "",
                Rent = "28,150,450,1000,1200,1400",
                Value = 320,
                Level = 0,
                UpgradeCost = 200,
                Col = 1,
                Row = 2,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 36,
                Name = "Tram 19",
                Description = ".",
                Color = Colors.None,
                Image = "",
                Rent = "25,50,100,200",
                Value = 200,
                Level = 0,
                UpgradeCost = 0,
                Col = 1,
                Row = 2,
                Type = Types.Transport,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 37,
                Name = "Chance",
                Description = ".",
                Color = Colors.None,
                Image = "",
                Rent = "",
                Value = 0,
                Level = 0,
                UpgradeCost = 0,
                Col = 1,
                Row = 2,
                Type = Types.Chance,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 38,
                Name = "",
                Description = ".",
                Color = Colors.DarkBlue,
                Image = "",
                Rent = "35,175,500,1100,1300,1500",
                Value = 350,
                Level = 0,
                UpgradeCost = 200,
                Col = 1,
                Row = 2,
                Type = Types.Property,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 39,
                Name = "Super Tax",
                Description = "You were drunk during your exam. Pay your resit cost.",
                Color = Colors.None,
                Image = "",
                Rent = "200",
                Value = 0,
                Level = 0,
                UpgradeCost = 0,
                Col = 1,
                Row = 2,
                Type = Types.Penalty,
                SetNumber = 1
            });
            modelBuilder.Entity<Card>().HasData(new
            {
                Id = 40,
                Name = "",
                Description = ".",
                Color = Colors.DarkBlue,
                Image = "",
                Rent = "50,200,600,1400,1700,2000",
                Value = 400,
                Level = 0,
                UpgradeCost = 200,
                Col = 1,
                Row = 2,
                Type = Types.Property,
                SetNumber = 1
            });
        }
    }
}
