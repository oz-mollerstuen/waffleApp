﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using waffle.Models;

#nullable disable

namespace waffleApp.Migrations
{
    [DbContext(typeof(waffleContext))]
    [Migration("20230105185703_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("waffle.Models.People", b =>
                {
                    b.Property<int>("person_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("age")
                        .HasColumnType("longtext");

                    b.Property<string>("birthday")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.HasKey("person_id");

                    b.ToTable("peoples");
                });

            modelBuilder.Entity("waffle.Models.Pizza", b =>
                {
                    b.Property<int>("pizza_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .HasColumnType("longtext");

                    b.HasKey("pizza_id");

                    b.ToTable("pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
