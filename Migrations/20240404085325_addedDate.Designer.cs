﻿// <auto-generated />
using System;
using Asset_Tracking_with_Entity_Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asset_Tracking_with_Entity_Framework.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240404085325_addedDate")]
    partial class addedDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Device")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Device = "Phone",
                            Model = "Iphone",
                            OfficeId = 1,
                            Price = 500,
                            PurchaseDate = new DateTime(2024, 4, 4, 10, 53, 25, 361, DateTimeKind.Local).AddTicks(820)
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
                            ConversionRate = 10f,
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
                            ConversionRate = 1.2f,
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
