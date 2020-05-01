﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TV_Show_Ratings_Core_Web_App.Models;

namespace TV_Show_Ratings_Core_Web_App.Migrations
{
    [DbContext(typeof(TV_Show_Ratings_DataContext))]
    partial class TV_Show_Ratings_DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TV_Show_Ratings_Core_Web_App.BusinessModel.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RatingValue")
                        .HasColumnType("int");

                    b.Property<int>("SubscriberId")
                        .HasColumnType("int");

                    b.Property<int>("TVShowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubscriberId");

                    b.HasIndex("TVShowId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("TV_Show_Ratings_Core_Web_App.BusinessModel.Subscriber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubscriberName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subscriber");
                });

            modelBuilder.Entity("TV_Show_Ratings_Core_Web_App.BusinessModel.TVChannel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChannelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Established")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TVChannel");
                });

            modelBuilder.Entity("TV_Show_Ratings_Core_Web_App.BusinessModel.TVShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShowName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TVChannelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TVChannelId");

                    b.ToTable("TVShow");
                });

            modelBuilder.Entity("TV_Show_Ratings_Core_Web_App.BusinessModel.Rating", b =>
                {
                    b.HasOne("TV_Show_Ratings_Core_Web_App.BusinessModel.Subscriber", "Subscriber")
                        .WithMany()
                        .HasForeignKey("SubscriberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TV_Show_Ratings_Core_Web_App.BusinessModel.TVShow", "TVShow")
                        .WithMany()
                        .HasForeignKey("TVShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TV_Show_Ratings_Core_Web_App.BusinessModel.TVShow", b =>
                {
                    b.HasOne("TV_Show_Ratings_Core_Web_App.BusinessModel.TVChannel", "TvChannel")
                        .WithMany()
                        .HasForeignKey("TVChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
