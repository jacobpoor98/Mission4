﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission04.Models;

namespace Mission04.Migrations
{
    [DbContext(typeof(MoviesContext))]
    [Migration("20220125225618_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission04.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER")
                        .HasMaxLength(4);

                    b.HasKey("MovieID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Horror/Suspense",
                            Director = "Francis Lawrence",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "I Am Legend",
                            Year = 2007
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Action/Adventure",
                            Director = "Mel Gibson",
                            Edited = false,
                            LentTo = "",
                            Notes = "Such an inspiring movie!",
                            Rating = "R",
                            Title = "Hacksaw Ridge",
                            Year = 2016
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Comedy",
                            Director = "Jake Kasdan",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Jumanji: The Next Level",
                            Year = 2017
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
