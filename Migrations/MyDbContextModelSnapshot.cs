﻿// <auto-generated />
using System;
using Asset_Tracking_with_Entity_Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asset_Tracking_with_Entity_Framework.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Asset_Tracking_with_Entity_Framework.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Model = "Iphone 8",
                            OfficeId = 1,
                            Price = 500,
                            PurchaseDate = new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 2,
                            Model = "Samsung Galaxy",
                            OfficeId = 2,
                            Price = 300,
                            PurchaseDate = new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 3,
                            Model = "OnePlus",
                            OfficeId = 3,
                            Price = 200,
                            PurchaseDate = new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 4,
                            Model = "Nokia 3310",
                            OfficeId = 2,
                            Price = 60,
                            PurchaseDate = new DateTime(2002, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 5,
                            Model = "Macbooc Air",
                            OfficeId = 3,
                            Price = 800,
                            PurchaseDate = new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 6,
                            Model = "Asus TUF Dash",
                            OfficeId = 1,
                            Price = 800,
                            PurchaseDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 7,
                            Model = "Lenovo Thinkpad",
                            OfficeId = 2,
                            Price = 800,
                            PurchaseDate = new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        });
                });

            modelBuilder.Entity("Asset_Tracking_with_Entity_Framework.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("ConversionRate")
                        .HasColumnType("real");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConversionRate = 10.54f,
                            Currency = "SEK",
                            Name = "Skövde"
                        },
                        new
                        {
                            Id = 2,
                            ConversionRate = 1f,
                            Currency = "USD",
                            Name = "Boston"
                        },
                        new
                        {
                            Id = 3,
                            ConversionRate = 0.92f,
                            Currency = "EUR",
                            Name = "Paris"
                        });
                });

            modelBuilder.Entity("Asset_Tracking_with_Entity_Framework.Asset", b =>
                {
                    b.HasOne("Asset_Tracking_with_Entity_Framework.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");
                });
#pragma warning restore 612, 618
        }
    }
}