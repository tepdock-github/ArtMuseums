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
    [Migration("20221217193501_Initialv3")]
    partial class Initialv3
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
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
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
                            Id = "3afac7d0-c751-4fc6-9f3d-b6c8e22fb05f",
                            Country = "France",
                            Name = "Van Gogh"
                        },
                        new
                        {
                            Id = "e528467c-2dfe-48fa-9e1a-739d2d0c0cd2",
                            Country = "Russia",
                            Name = "Ivan Aivazovski"
                        },
                        new
                        {
                            Id = "ffb62ca6-0c3e-4a64-9b22-5af9d79c08ab",
                            Country = "Belarus",
                            Name = "Mark Shagal"
                        });
                });

            modelBuilder.Entity("Entities.Models.ArtMuseum", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
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
                            Id = "033c8277-9be5-451b-9936-87f4b07caae7",
                            Adress = "st qwerty, 34",
                            Name = "General art museum"
                        },
                        new
                        {
                            Id = "df77f745-2310-4bba-b157-c4f3434ff749",
                            Adress = "street yung, 25",
                            Name = "Museum of modern arts"
                        });
                });

            modelBuilder.Entity("Entities.Models.Exhibition", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ExpositionId");

                    b.Property<string>("ArtMuseumId")
                        .HasColumnType("nvarchar(450)");

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
                            Id = "e5368172-b396-4960-8e67-ddffceefc98b",
                            ArtMuseumId = "033c8277-9be5-451b-9936-87f4b07caae7",
                            Name = "exhibition of belarusian artists"
                        },
                        new
                        {
                            Id = "e177f248-6517-449c-9200-16b673c5beff",
                            ArtMuseumId = "df77f745-2310-4bba-b157-c4f3434ff749",
                            Description = "exhibition of famous paintings from different times",
                            Name = "arts of world"
                        });
                });

            modelBuilder.Entity("Entities.Models.Painting", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PaintingId");

                    b.Property<string>("ArtistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExhibitionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("ExhibitionId");

                    b.ToTable("Paintings");

                    b.HasData(
                        new
                        {
                            Id = "07ba5109-8aec-48ee-b7d9-21e2ce4f3312",
                            ArtistId = "ffb62ca6-0c3e-4a64-9b22-5af9d79c08ab",
                            Category = "Abstract",
                            Description = "Прогулка - Марк Захарович Шагал. 1917-1918. Холст, масло 169,6x163,4 см",
                            ExhibitionId = "e5368172-b396-4960-8e67-ddffceefc98b",
                            Name = "a walk",
                            Picture = "https://res.cloudinary.com/dkt2qwk4f/image/upload/v1670924106/progulka-shagal_d0mxfj.jpg",
                            Year = "1918"
                        },
                        new
                        {
                            Id = "9d944131-b6ee-4b76-825b-fa6163a27787",
                            ArtistId = "ffb62ca6-0c3e-4a64-9b22-5af9d79c08ab",
                            Category = "Modern",
                            Description = "Прогулка - Марк Захарович Шагал. 1917-1918. Холст, масло 169,6x163,4 см",
                            ExhibitionId = "e177f248-6517-449c-9200-16b673c5beff",
                            Name = "Three Candles",
                            Picture = "https://res.cloudinary.com/dkt2qwk4f/image/upload/v1670924115/triCvechiShagal_bvnhcf.jpg",
                            Year = "1940"
                        },
                        new
                        {
                            Id = "58bde6fc-74f6-41ba-8d60-39424211cfc6",
                            ArtistId = "3afac7d0-c751-4fc6-9f3d-b6c8e22fb05f",
                            Category = "Expresionism",
                            Description = "The Starry Night (Dutch: De sterrennacht) is an oil-on-canvas painting by the Dutch Post-Impressionist painter Vincent van Gogh. Painted in June 1889, it depicts the view from the east-facing window of his asylum room at Saint-Rémy-de-Provence, just before sunrise, with the addition of an imaginary village.",
                            ExhibitionId = "e5368172-b396-4960-8e67-ddffceefc98b",
                            Name = "Starry Night",
                            Picture = "https://res.cloudinary.com/dkt2qwk4f/image/upload/v1670873513/VanGogh-starry_night_ballance1_dj6w1i.jpg",
                            Year = "1889"
                        });
                });

            modelBuilder.Entity("Entities.Models.Purchase", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PurchaseId");

                    b.Property<string>("TourName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("Entities.Models.Tour", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("TourId");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExhibitionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TourPlaces")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExhibitionId");

                    b.ToTable("Tours");

                    b.HasData(
                        new
                        {
                            Id = "805ed4d2-bcf3-48cf-a722-94db044d43ac",
                            ExhibitionId = "e5368172-b396-4960-8e67-ddffceefc98b",
                            TourPlaces = 20
                        },
                        new
                        {
                            Id = "579acbef-ffbe-42fe-b26d-5f8befa41889",
                            ExhibitionId = "e5368172-b396-4960-8e67-ddffceefc98b",
                            TourPlaces = 5
                        },
                        new
                        {
                            Id = "769a5cb1-9b03-447f-a2d9-c8589a0c901d",
                            ExhibitionId = "e177f248-6517-449c-9200-16b673c5beff",
                            TourPlaces = 20
                        },
                        new
                        {
                            Id = "b177f615-4df7-4aa8-9f98-21f7a9a18f32",
                            ExhibitionId = "e177f248-6517-449c-9200-16b673c5beff",
                            TourPlaces = 5
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b4542aab-db51-4691-ad13-9a1173575e35",
                            ConcurrencyStamp = "41d5b981-91e0-4a13-8176-106313ac9040",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "f4b48d59-090c-413f-9514-404e41698b6c",
                            ConcurrencyStamp = "857f14be-e0d0-4258-a41e-c4b42c4fe98d",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Exhibition", b =>
                {
                    b.HasOne("Entities.Models.ArtMuseum", "ArtMuseum")
                        .WithMany("Exhibitions")
                        .HasForeignKey("ArtMuseumId");

                    b.Navigation("ArtMuseum");
                });

            modelBuilder.Entity("Entities.Models.Painting", b =>
                {
                    b.HasOne("Entities.Models.Artist", "Artist")
                        .WithMany("Paintings")
                        .HasForeignKey("ArtistId");

                    b.HasOne("Entities.Models.Exhibition", "Exhibition")
                        .WithMany("Paintigs")
                        .HasForeignKey("ExhibitionId");

                    b.Navigation("Artist");

                    b.Navigation("Exhibition");
                });

            modelBuilder.Entity("Entities.Models.Tour", b =>
                {
                    b.HasOne("Entities.Models.Exhibition", "Exhibition")
                        .WithMany("Tours")
                        .HasForeignKey("ExhibitionId");

                    b.Navigation("Exhibition");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
#pragma warning restore 612, 618
        }
    }
}
