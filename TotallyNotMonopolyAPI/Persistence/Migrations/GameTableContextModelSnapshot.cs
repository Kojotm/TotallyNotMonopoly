﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(GameTableContext))]
    partial class GameTableContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Cards.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Col")
                        .HasColumnType("int");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.Property<int>("SetNumber")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("UpgradeCost")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TableCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Col = 2,
                            Color = 8,
                            Description = "This is the start point.",
                            Image = "url('../../assets/start-tile.png')",
                            Level = 0,
                            Name = "Go",
                            Rent = "",
                            Row = 2,
                            SetNumber = 1,
                            Type = 5,
                            UpgradeCost = 0,
                            Value = 200
                        },
                        new
                        {
                            Id = 2,
                            Col = 2,
                            Color = 0,
                            Description = "A famous bar amoung students not far from the university campus.",
                            Image = "",
                            Level = 0,
                            Name = "Szertár",
                            Rent = "2,10,30,90,160,250",
                            Row = 1,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 50,
                            Value = 60
                        },
                        new
                        {
                            Id = 3,
                            Col = 2,
                            Color = 8,
                            Description = "Community Chest.",
                            Image = "",
                            Level = 0,
                            Name = "Community Chest",
                            Rent = "",
                            Row = 1,
                            SetNumber = 1,
                            Type = 1,
                            UpgradeCost = 0,
                            Value = 0
                        },
                        new
                        {
                            Id = 4,
                            Col = 2,
                            Color = 0,
                            Description = "A jug of Arany Ászok is only 330 HUF.",
                            Image = "",
                            Level = 0,
                            Name = "Bak Egér Borozó",
                            Rent = "4,20,60,180,320,450",
                            Row = 1,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 50,
                            Value = 60
                        },
                        new
                        {
                            Id = 5,
                            Col = 2,
                            Color = 8,
                            Description = "You were hangover during your exam. Pay your resit cost.",
                            Image = "",
                            Level = 0,
                            Name = "Income Tax",
                            Rent = "100",
                            Row = 1,
                            SetNumber = 1,
                            Type = 4,
                            UpgradeCost = 0,
                            Value = 0
                        },
                        new
                        {
                            Id = 6,
                            Col = 2,
                            Color = 8,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "Tram 4-6",
                            Rent = "25,50,100,200",
                            Row = 1,
                            SetNumber = 1,
                            Type = 2,
                            UpgradeCost = 0,
                            Value = 200
                        },
                        new
                        {
                            Id = 7,
                            Col = 2,
                            Color = 1,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "6,30,90,270,400,550",
                            Row = 1,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 50,
                            Value = 100
                        },
                        new
                        {
                            Id = 8,
                            Col = 2,
                            Color = 8,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "Chance",
                            Rent = "",
                            Row = 1,
                            SetNumber = 1,
                            Type = 0,
                            UpgradeCost = 0,
                            Value = 0
                        },
                        new
                        {
                            Id = 9,
                            Col = 2,
                            Color = 1,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "6,30,90,270,400,550",
                            Row = 1,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 50,
                            Value = 100
                        },
                        new
                        {
                            Id = 10,
                            Col = 2,
                            Color = 1,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "8,40,100,300,450,600",
                            Row = 1,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 50,
                            Value = 120
                        },
                        new
                        {
                            Id = 11,
                            Col = 2,
                            Color = 8,
                            Description = "This is the jail.",
                            Image = "url('../../assets/jail-tile.png')",
                            Level = 0,
                            Name = "Jail",
                            Rent = "",
                            Row = 2,
                            SetNumber = 1,
                            Type = 5,
                            UpgradeCost = 0,
                            Value = 50
                        },
                        new
                        {
                            Id = 12,
                            Col = 1,
                            Color = 2,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "10,50,150,450,625,750",
                            Row = 2,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 100,
                            Value = 140
                        },
                        new
                        {
                            Id = 13,
                            Col = 1,
                            Color = 8,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "Electric Company",
                            Rent = "4,10",
                            Row = 2,
                            SetNumber = 1,
                            Type = 6,
                            UpgradeCost = 0,
                            Value = 150
                        },
                        new
                        {
                            Id = 14,
                            Col = 1,
                            Color = 2,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "10,50,150,450,625,750",
                            Row = 2,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 100,
                            Value = 140
                        },
                        new
                        {
                            Id = 15,
                            Col = 1,
                            Color = 2,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "12,60,180,500,700,900",
                            Row = 2,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 100,
                            Value = 160
                        },
                        new
                        {
                            Id = 16,
                            Col = 1,
                            Color = 8,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "Tram 1",
                            Rent = "25,50,100,200",
                            Row = 2,
                            SetNumber = 1,
                            Type = 2,
                            UpgradeCost = 0,
                            Value = 200
                        },
                        new
                        {
                            Id = 17,
                            Col = 1,
                            Color = 3,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "14,70,200,550,700,900",
                            Row = 2,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 100,
                            Value = 180
                        },
                        new
                        {
                            Id = 18,
                            Col = 1,
                            Color = 8,
                            Description = "Community Chest.",
                            Image = "",
                            Level = 0,
                            Name = "Community Chest",
                            Rent = "",
                            Row = 2,
                            SetNumber = 1,
                            Type = 1,
                            UpgradeCost = 0,
                            Value = 0
                        },
                        new
                        {
                            Id = 19,
                            Col = 1,
                            Color = 3,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "14,70,200,550,700,900",
                            Row = 2,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 100,
                            Value = 180
                        },
                        new
                        {
                            Id = 20,
                            Col = 1,
                            Color = 3,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "16,80,220,600,800,1000",
                            Row = 2,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 100,
                            Value = 200
                        },
                        new
                        {
                            Id = 21,
                            Col = 2,
                            Color = 8,
                            Description = "It's your lucky day, you don't have to take the exam.",
                            Image = "url('../../assets/parking-tile.png')",
                            Level = 0,
                            Name = "Offered exam grade",
                            Rent = "",
                            Row = 2,
                            SetNumber = 1,
                            Type = 5,
                            UpgradeCost = 0,
                            Value = 0
                        },
                        new
                        {
                            Id = 22,
                            Col = 2,
                            Color = 4,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "18,90,250,700,875,1050",
                            Row = 1,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 150,
                            Value = 220
                        },
                        new
                        {
                            Id = 23,
                            Col = 2,
                            Color = 8,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "Chance",
                            Rent = "",
                            Row = 1,
                            SetNumber = 1,
                            Type = 0,
                            UpgradeCost = 0,
                            Value = 0
                        },
                        new
                        {
                            Id = 24,
                            Col = 2,
                            Color = 4,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "18,90,250,700,875,1050",
                            Row = 1,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 150,
                            Value = 220
                        },
                        new
                        {
                            Id = 25,
                            Col = 2,
                            Color = 4,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "20,100,300,750,925,1100",
                            Row = 1,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 150,
                            Value = 240
                        },
                        new
                        {
                            Id = 26,
                            Col = 2,
                            Color = 8,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "Tram 2",
                            Rent = "25,50,100,200",
                            Row = 1,
                            SetNumber = 1,
                            Type = 2,
                            UpgradeCost = 0,
                            Value = 200
                        },
                        new
                        {
                            Id = 27,
                            Col = 2,
                            Color = 5,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "22,110,330,800,975,1150",
                            Row = 1,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 150,
                            Value = 260
                        },
                        new
                        {
                            Id = 28,
                            Col = 2,
                            Color = 5,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "22,110,330,800,975,1150",
                            Row = 1,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 150,
                            Value = 260
                        },
                        new
                        {
                            Id = 29,
                            Col = 1,
                            Color = 8,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "Water works",
                            Rent = "4,10",
                            Row = 2,
                            SetNumber = 1,
                            Type = 6,
                            UpgradeCost = 0,
                            Value = 150
                        },
                        new
                        {
                            Id = 30,
                            Col = 2,
                            Color = 5,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "24,120,360,850,1025,1200",
                            Row = 1,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 150,
                            Value = 280
                        },
                        new
                        {
                            Id = 31,
                            Col = 2,
                            Color = 8,
                            Description = "It's NOT your lucky day, you have to resit your last exam.",
                            Image = "url('../../assets/go-to-jail-tile.png')",
                            Level = 0,
                            Name = "Go to your re-examination",
                            Rent = "",
                            Row = 2,
                            SetNumber = 1,
                            Type = 5,
                            UpgradeCost = 0,
                            Value = 0
                        },
                        new
                        {
                            Id = 32,
                            Col = 1,
                            Color = 6,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "26,130,390,900,1100,1275",
                            Row = 2,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 200,
                            Value = 300
                        },
                        new
                        {
                            Id = 33,
                            Col = 1,
                            Color = 6,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "26,130,390,900,1100,1275",
                            Row = 2,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 200,
                            Value = 300
                        },
                        new
                        {
                            Id = 34,
                            Col = 1,
                            Color = 8,
                            Description = "Community Chest.",
                            Image = "",
                            Level = 0,
                            Name = "Community Chest",
                            Rent = "",
                            Row = 2,
                            SetNumber = 1,
                            Type = 1,
                            UpgradeCost = 0,
                            Value = 0
                        },
                        new
                        {
                            Id = 35,
                            Col = 1,
                            Color = 6,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "28,150,450,1000,1200,1400",
                            Row = 2,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 200,
                            Value = 320
                        },
                        new
                        {
                            Id = 36,
                            Col = 1,
                            Color = 8,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "Tram 19",
                            Rent = "25,50,100,200",
                            Row = 2,
                            SetNumber = 1,
                            Type = 2,
                            UpgradeCost = 0,
                            Value = 200
                        },
                        new
                        {
                            Id = 37,
                            Col = 1,
                            Color = 8,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "Chance",
                            Rent = "",
                            Row = 2,
                            SetNumber = 1,
                            Type = 0,
                            UpgradeCost = 0,
                            Value = 0
                        },
                        new
                        {
                            Id = 38,
                            Col = 1,
                            Color = 7,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "35,175,500,1100,1300,1500",
                            Row = 2,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 200,
                            Value = 350
                        },
                        new
                        {
                            Id = 39,
                            Col = 1,
                            Color = 8,
                            Description = "You were drunk during your exam. Pay your resit cost.",
                            Image = "",
                            Level = 0,
                            Name = "Super Tax",
                            Rent = "200",
                            Row = 2,
                            SetNumber = 1,
                            Type = 4,
                            UpgradeCost = 0,
                            Value = 0
                        },
                        new
                        {
                            Id = 40,
                            Col = 1,
                            Color = 7,
                            Description = ".",
                            Image = "",
                            Level = 0,
                            Name = "",
                            Rent = "50,200,600,1400,1700,2000",
                            Row = 2,
                            SetNumber = 1,
                            Type = 3,
                            UpgradeCost = 200,
                            Value = 400
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
