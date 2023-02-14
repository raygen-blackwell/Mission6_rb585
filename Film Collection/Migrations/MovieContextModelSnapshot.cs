﻿// <auto-generated />
using Film_Collection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Film_Collection.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Film_Collection.Models.MovieRatings", b =>
                {
                    b.Property<int>("MovieId")
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

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Adventure/Musical",
                            Director = "Rone Clements, John Musker",
                            Edited = true,
                            LentTo = "",
                            MovieTitle = "Hercules",
                            Notes = "Best nostalgic movie ever!",
                            Rating = "G",
                            Year = 1997
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Action/Adventure",
                            Director = "Ryan Coogler",
                            Edited = true,
                            LentTo = "Taylor B.",
                            MovieTitle = "Black Panther:Wakanda Forever",
                            Notes = "",
                            Rating = "PG-13",
                            Year = 2022
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Musical/Romance",
                            Director = "Phyllida Lloyd",
                            Edited = true,
                            LentTo = "",
                            MovieTitle = "Mamma Mia!",
                            Notes = "Best for a girls night sing along.",
                            Rating = "PG-13",
                            Year = 20
                        });
                });
#pragma warning restore 612, 618
        }
    }
}