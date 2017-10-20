﻿// <auto-generated />
using LojaComputadores;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LojaComputadores.Migrations
{
    [DbContext(typeof(LojaContext))]
    [Migration("20171020025158_Adicionando url de imagem")]
    partial class Adicionandourldeimagem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LojaComputadores.Models.Computador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HD")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("PlacaMae");

                    b.Property<string>("PlacaVideo");

                    b.Property<float>("Preco");

                    b.Property<string>("Processador");

                    b.Property<string>("Ram")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Computadores");
                });
#pragma warning restore 612, 618
        }
    }
}
