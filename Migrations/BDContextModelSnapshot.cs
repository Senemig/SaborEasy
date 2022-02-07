﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sabor_Easy_MVC.Models;

namespace Sabor_Easy_MVC.Migrations
{
    [DbContext(typeof(BDContext))]
    partial class BDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Sabor_Easy_MVC.Models.Mensagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Msg")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("msgDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Mensagens");
                });

            modelBuilder.Entity("Sabor_Easy_MVC.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("hashtags")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("imagePath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("postDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("titulo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

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

            modelBuilder.Entity("Sabor_Easy_MVC.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
