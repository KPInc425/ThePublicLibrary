﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YmiInfrastructure.Data;

#nullable disable

namespace YmiApplication.Data.Migrations
{
    [DbContext(typeof(YmiDbContext))]
    [Migration("20230723001512_init9")]
    partial class init9
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("YmiCore.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("LocationRegionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LocationRegionId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("YmiCore.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("CityCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CurrentCityId")
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrentDay")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DifficultyLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxDays")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("TEXT");

                    b.Property<int>("PlayerLuck")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StartLocation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TimeOfDay")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CurrentCityId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("YmiCore.Entities.LocationRegion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ControllingFaction")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("LocationRegions");
                });

            modelBuilder.Entity("YmiCore.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UpbringingType")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("YmiCore.Entities.StorageContainer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PlayerId")
                        .HasColumnType("TEXT");

                    b.Property<int>("SlotCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.ToTable("StorageContainers");
                });

            modelBuilder.Entity("YmiCore.Entities.StorageItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ItemType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<Guid?>("StorageContainerId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StorageContainerId");

                    b.ToTable("StorageItems");
                });

            modelBuilder.Entity("YmiCore.Entities.City", b =>
                {
                    b.HasOne("YmiCore.Entities.LocationRegion", "LocationRegion")
                        .WithMany("Cities")
                        .HasForeignKey("LocationRegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationRegion");
                });

            modelBuilder.Entity("YmiCore.Entities.Game", b =>
                {
                    b.HasOne("YmiCore.Entities.City", "CurrentCity")
                        .WithMany()
                        .HasForeignKey("CurrentCityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("YmiCore.Entities.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentCity");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("YmiCore.Entities.LocationRegion", b =>
                {
                    b.HasOne("YmiCore.Entities.Game", null)
                        .WithMany("LocationRegions")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("YmiCore.Entities.StorageContainer", b =>
                {
                    b.HasOne("YmiCore.Entities.Game", null)
                        .WithMany("LostItemsStorageContainers")
                        .HasForeignKey("GameId");

                    b.HasOne("YmiCore.Entities.Player", null)
                        .WithMany("StorageContainers")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("YmiCore.Entities.StorageItem", b =>
                {
                    b.HasOne("YmiCore.Entities.StorageContainer", null)
                        .WithMany("StorageItems")
                        .HasForeignKey("StorageContainerId");
                });

            modelBuilder.Entity("YmiCore.Entities.Game", b =>
                {
                    b.Navigation("LocationRegions");

                    b.Navigation("LostItemsStorageContainers");
                });

            modelBuilder.Entity("YmiCore.Entities.LocationRegion", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("YmiCore.Entities.Player", b =>
                {
                    b.Navigation("StorageContainers");
                });

            modelBuilder.Entity("YmiCore.Entities.StorageContainer", b =>
                {
                    b.Navigation("StorageItems");
                });
#pragma warning restore 612, 618
        }
    }
}
