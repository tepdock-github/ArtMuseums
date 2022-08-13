﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArtMuseums.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220813154518_updateMuseums")]
    partial class updateMuseums
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Artist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ArtistId");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3afac7d0-c751-4fc6-9f3d-b6c8e22fb05f"),
                            Country = "France",
                            Name = "Van Gogh"
                        },
                        new
                        {
                            Id = new Guid("e528467c-2dfe-48fa-9e1a-739d2d0c0cd2"),
                            Country = "Russia",
                            Name = "Ivan Aivazovski"
                        },
                        new
                        {
                            Id = new Guid("ffb62ca6-0c3e-4a64-9b22-5af9d79c08ab"),
                            Country = "Belarus",
                            Name = "Mark Shagal"
                        });
                });

            modelBuilder.Entity("Entities.Models.ArtMuseum", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ArtMuseumId");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ArtMuseums");

                    b.HasData(
                        new
                        {
                            Id = new Guid("033c8277-9be5-451b-9936-87f4b07caae7"),
                            Adress = "st qwerty, 34",
                            Name = "General art museum"
                        },
                        new
                        {
                            Id = new Guid("df77f745-2310-4bba-b157-c4f3434ff749"),
                            Adress = "street yung, 25",
                            Name = "Museum of modern arts"
                        });
                });

            modelBuilder.Entity("Entities.Models.Busket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PurchaseId");

                    b.Property<Guid>("TourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Buskets");
                });

            modelBuilder.Entity("Entities.Models.Exhibition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ExpositionId");

                    b.Property<Guid>("ArtMuseumId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArtMuseumId");

                    b.ToTable("Exhibitions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e5368172-b396-4960-8e67-ddffceefc98b"),
                            ArtMuseumId = new Guid("033c8277-9be5-451b-9936-87f4b07caae7"),
                            Name = "exhibition of belarusian artists"
                        },
                        new
                        {
                            Id = new Guid("e177f248-6517-449c-9200-16b673c5beff"),
                            ArtMuseumId = new Guid("df77f745-2310-4bba-b157-c4f3434ff749"),
                            Description = "exhibition of famous paintings from different times",
                            Name = "arts of world"
                        });
                });

            modelBuilder.Entity("Entities.Models.Painting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PaintingId");

                    b.Property<Guid>("ArtistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ExhibitionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("ExhibitionId");

                    b.ToTable("Paintings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("07ba5109-8aec-48ee-b7d9-21e2ce4f3312"),
                            ArtistId = new Guid("ffb62ca6-0c3e-4a64-9b22-5af9d79c08ab"),
                            Description = "Прогулка - Марк Захарович Шагал. 1917-1918. Холст, масло 169,6x163,4 см",
                            ExhibitionId = new Guid("e5368172-b396-4960-8e67-ddffceefc98b"),
                            Name = "a walk",
                            Picture = "D:/asp.net core/pictures/progulka-shagal+.jpg",
                            Year = 1918
                        },
                        new
                        {
                            Id = new Guid("9d944131-b6ee-4b76-825b-fa6163a27787"),
                            ArtistId = new Guid("ffb62ca6-0c3e-4a64-9b22-5af9d79c08ab"),
                            ExhibitionId = new Guid("e177f248-6517-449c-9200-16b673c5beff"),
                            Name = "Three Candles",
                            Picture = "D:/asp.net core/pictures/triCvechiShagal.jpg",
                            Year = 1940
                        },
                        new
                        {
                            Id = new Guid("58bde6fc-74f6-41ba-8d60-39424211cfc6"),
                            ArtistId = new Guid("3afac7d0-c751-4fc6-9f3d-b6c8e22fb05f"),
                            ExhibitionId = new Guid("e5368172-b396-4960-8e67-ddffceefc98b"),
                            Name = "Starry Night",
                            Picture = "D:/asp.net core/pictures/VanGogh-starry_night_ballance1.jpg",
                            Year = 1889
                        });
                });

            modelBuilder.Entity("Entities.Models.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TicketId");

                    b.Property<int>("TicketCost")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<Guid>("TourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Entities.Models.Tour", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TourId");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ExhibitionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TourPlaces")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExhibitionId");

                    b.ToTable("Tours");

                    b.HasData(
                        new
                        {
                            Id = new Guid("805ed4d2-bcf3-48cf-a722-94db044d43ac"),
                            ExhibitionId = new Guid("e5368172-b396-4960-8e67-ddffceefc98b"),
                            TourPlaces = 20
                        },
                        new
                        {
                            Id = new Guid("579acbef-ffbe-42fe-b26d-5f8befa41889"),
                            ExhibitionId = new Guid("e5368172-b396-4960-8e67-ddffceefc98b"),
                            TourPlaces = 5
                        },
                        new
                        {
                            Id = new Guid("769a5cb1-9b03-447f-a2d9-c8589a0c901d"),
                            ExhibitionId = new Guid("e177f248-6517-449c-9200-16b673c5beff"),
                            TourPlaces = 20
                        },
                        new
                        {
                            Id = new Guid("b177f615-4df7-4aa8-9f98-21f7a9a18f32"),
                            ExhibitionId = new Guid("e177f248-6517-449c-9200-16b673c5beff"),
                            TourPlaces = 5
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserId");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Models.Exhibition", b =>
                {
                    b.HasOne("Entities.Models.ArtMuseum", "ArtMuseum")
                        .WithMany("Exhibitions")
                        .HasForeignKey("ArtMuseumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArtMuseum");
                });

            modelBuilder.Entity("Entities.Models.Painting", b =>
                {
                    b.HasOne("Entities.Models.Artist", "Artist")
                        .WithMany("Paintings")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Exhibition", "Exhibition")
                        .WithMany("Paintigs")
                        .HasForeignKey("ExhibitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Exhibition");
                });

            modelBuilder.Entity("Entities.Models.Ticket", b =>
                {
                    b.HasOne("Entities.Models.Tour", "Tour")
                        .WithMany("Tickets")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.Tour", b =>
                {
                    b.HasOne("Entities.Models.Exhibition", "Exhibition")
                        .WithMany("Tours")
                        .HasForeignKey("ExhibitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exhibition");
                });

            modelBuilder.Entity("Entities.Models.Artist", b =>
                {
                    b.Navigation("Paintings");
                });

            modelBuilder.Entity("Entities.Models.ArtMuseum", b =>
                {
                    b.Navigation("Exhibitions");
                });

            modelBuilder.Entity("Entities.Models.Exhibition", b =>
                {
                    b.Navigation("Paintigs");

                    b.Navigation("Tours");
                });

            modelBuilder.Entity("Entities.Models.Tour", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
