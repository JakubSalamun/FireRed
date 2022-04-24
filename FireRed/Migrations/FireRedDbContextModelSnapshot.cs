﻿// <auto-generated />
using System;
using FireRed.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FireRed.Migrations
{
    [DbContext(typeof(FireRedDbContext))]
    partial class FireRedDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FireRed.Entities.PokemonMoves", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MoveAccurancy")
                        .HasColumnType("int");

                    b.Property<string>("MoveCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MoveLV")
                        .HasColumnType("int");

                    b.Property<string>("MoveName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovePP")
                        .HasColumnType("int");

                    b.Property<int>("MovePower")
                        .HasColumnType("int");

                    b.Property<string>("MoveType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PokemomId")
                        .HasColumnType("int");

                    b.Property<bool>("PokemonCanUse")
                        .HasColumnType("bit");

                    b.Property<int?>("PokemonsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PokemonsId");

                    b.ToTable("PokemonMoves");
                });

            modelBuilder.Entity("FireRed.Entities.PokemonStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ATK")
                        .HasColumnType("int");

                    b.Property<int>("DEF")
                        .HasColumnType("int");

                    b.Property<int>("HP")
                        .HasColumnType("int");

                    b.Property<int>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int>("SPATK")
                        .HasColumnType("int");

                    b.Property<int>("SPDEF")
                        .HasColumnType("int");

                    b.Property<int>("SPEED")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PokemonStats");
                });

            modelBuilder.Entity("FireRed.Entities.Pokemons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GenderType")
                        .HasColumnType("int");

                    b.Property<int>("Lv")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PokemonMovesId")
                        .HasColumnType("int");

                    b.Property<int>("PokemonStatsId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PokemonStatsId")
                        .IsUnique();

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("FireRed.Entities.PokemonMoves", b =>
                {
                    b.HasOne("FireRed.Entities.Pokemons", "Pokemons")
                        .WithMany("PokemonMoves")
                        .HasForeignKey("PokemonsId");

                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("FireRed.Entities.Pokemons", b =>
                {
                    b.HasOne("FireRed.Entities.PokemonStats", "PokemonStats")
                        .WithOne("Pokemons")
                        .HasForeignKey("FireRed.Entities.Pokemons", "PokemonStatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PokemonStats");
                });

            modelBuilder.Entity("FireRed.Entities.PokemonStats", b =>
                {
                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("FireRed.Entities.Pokemons", b =>
                {
                    b.Navigation("PokemonMoves");
                });
#pragma warning restore 612, 618
        }
    }
}
