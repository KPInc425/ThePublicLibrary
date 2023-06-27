﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YMI.YmiInfrastructure.Data;

#nullable disable

namespace YMI.YmiApplication.Data.Migrations
{
    [DbContext(typeof(YmiDbContext))]
    partial class YmiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("ActorVideo", b =>
                {
                    b.Property<Guid>("ActorsId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VideosId")
                        .HasColumnType("TEXT");

                    b.HasKey("ActorsId", "VideosId");

                    b.HasIndex("VideosId");

                    b.ToTable("ActorVideo");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Actor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Video", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("PageCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("VideoStoreId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("VideoStoreId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.VideoCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("VideoCategoryId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("VideoId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("VideoCategoryId");

                    b.HasIndex("VideoId");

                    b.ToTable("VideoCategories");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.VideoCopy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Condition")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CopySequence")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VideoId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("VideoId");

                    b.ToTable("VideoCopies");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.VideoStore", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("VideoStores");
                });

            modelBuilder.Entity("ActorVideo", b =>
                {
                    b.HasOne("YMI.YmiCore.Entities.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YMI.YmiCore.Entities.Video", null)
                        .WithMany()
                        .HasForeignKey("VideosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Actor", b =>
                {
                    b.OwnsOne("YMI.YmiCore.Entities.FullNameVO", "Name", b1 =>
                        {
                            b1.Property<Guid>("ActorId")
                                .HasColumnType("TEXT");

                            b1.HasKey("ActorId");

                            b1.ToTable("Actors");

                            b1.WithOwner()
                                .HasForeignKey("ActorId");
                        });

                    b.Navigation("Name")
                        .IsRequired();
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Video", b =>
                {
                    b.HasOne("YMI.YmiCore.Entities.VideoStore", null)
                        .WithMany("Videos")
                        .HasForeignKey("VideoStoreId");

                    b.OwnsOne("YMI.YmiCore.Entities.IsbnVO", "Isbn", b1 =>
                        {
                            b1.Property<Guid>("VideoId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Isbn")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("VideoId");

                            b1.HasIndex("Isbn")
                                .IsUnique()
                                .HasDatabaseName("Index_Isbn")
                                .HasAnnotation("SqlServer:Clustered", false);

                            b1.ToTable("Videos");

                            b1.WithOwner()
                                .HasForeignKey("VideoId");
                        });

                    b.Navigation("Isbn")
                        .IsRequired();
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.VideoCategory", b =>
                {
                    b.HasOne("YMI.YmiCore.Entities.VideoCategory", null)
                        .WithMany("VideoCategories")
                        .HasForeignKey("VideoCategoryId");

                    b.HasOne("YMI.YmiCore.Entities.Video", null)
                        .WithMany("VideoCategories")
                        .HasForeignKey("VideoId");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.VideoCopy", b =>
                {
                    b.HasOne("YMI.YmiCore.Entities.Video", "Video")
                        .WithMany("VideoCopies")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Video");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.VideoStore", b =>
                {
                    b.OwnsOne("YMI.YmiCore.Entities.PhysicalAddyVO", "Address", b1 =>
                        {
                            b1.Property<Guid>("VideoStoreId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("StateProvince")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street1")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street2")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("VideoStoreId");

                            b1.ToTable("VideoStores");

                            b1.WithOwner()
                                .HasForeignKey("VideoStoreId");
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.Video", b =>
                {
                    b.Navigation("VideoCategories");

                    b.Navigation("VideoCopies");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.VideoCategory", b =>
                {
                    b.Navigation("VideoCategories");
                });

            modelBuilder.Entity("YMI.YmiCore.Entities.VideoStore", b =>
                {
                    b.Navigation("Videos");
                });
#pragma warning restore 612, 618
        }
    }
}
