﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParks.Models;

namespace NationalParks.Migrations
{
    [DbContext(typeof(NationalParksContext))]
    partial class NationalParksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NationalParks.Models.NationalPark", b =>
                {
                    b.Property<int>("NationalParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnnualVisitors");

                    b.Property<string>("DateEstablished")
                        .IsRequired();

                    b.Property<double>("NationalParkArea");

                    b.Property<string>("NationalParkDescription")
                        .IsRequired();

                    b.Property<string>("NationalParkLocation")
                        .IsRequired();

                    b.Property<string>("NationalParkName")
                        .IsRequired();

                    b.HasKey("NationalParkId");

                    b.ToTable("NationalPark");

                    b.HasData(
                        new
                        {
                            NationalParkId = 1,
                            AnnualVisitors = 4020288,
                            DateEstablished = "March 1, 1872",
                            NationalParkArea = 2219790.71,
                            NationalParkDescription = "test",
                            NationalParkLocation = "Wyoming, Montana, Idaha",
                            NationalParkName = "YellowStone"
                        },
                        new
                        {
                            NationalParkId = 2,
                            AnnualVisitors = 1246053,
                            DateEstablished = "September 25, 1890",
                            NationalParkArea = 404062.63,
                            NationalParkDescription = "test",
                            NationalParkLocation = "California",
                            NationalParkName = "Sequoia"
                        });
                });

            modelBuilder.Entity("NationalParks.Models.StatePark", b =>
                {
                    b.Property<int>("StateParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateEstablished");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("StateParkDescription")
                        .IsRequired();

                    b.Property<string>("StateParkName")
                        .IsRequired();

                    b.HasKey("StateParkId");

                    b.ToTable("StatePark");

                    b.HasData(
                        new
                        {
                            StateParkId = 1,
                            State = "Oregon",
                            StateParkDescription = "test",
                            StateParkName = "Goose Lake"
                        },
                        new
                        {
                            StateParkId = 2,
                            State = "Oregon",
                            StateParkDescription = "test",
                            StateParkName = "Smith Rock"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
