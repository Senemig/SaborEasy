﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sabor_Easy_MVC.Models;

namespace Sabor_Easy_MVC.Migrations
{
    [DbContext(typeof(BDContext))]
    [Migration("20220207121155_CreateReceitas2")]
    partial class CreateReceitas2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Sabor_Easy_MVC.Models.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ingredientes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ModoPreparo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Porcoes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TempoPreparo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("dataReceita")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("imagePath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Receitas");
                });
#pragma warning restore 612, 618
        }
    }
}
