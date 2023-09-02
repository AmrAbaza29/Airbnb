﻿// <auto-generated />
using System;
using Airbnb.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Airbnb.DAL.Migrations
{
    [DbContext(typeof(RentContext))]
    partial class RentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Airbnb.DAL.Amenity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amenities");
                });

            modelBuilder.Entity("Airbnb.DAL.Images", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AmenityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RuleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AmenityId")
                        .IsUnique()
                        .HasFilter("[AmenityId] IS NOT NULL");

                    b.HasIndex("PropertyId");

                    b.HasIndex("RuleId")
                        .IsUnique()
                        .HasFilter("[RuleId] IS NOT NULL");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Airbnb.DAL.Property", b =>
                {
                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Governorate")
                        .HasColumnType("int");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumOfPeople")
                        .HasColumnType("int");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PropType")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            UserID = new Guid("4201d29d-4239-43fb-a907-7c7ca0836c9f"),
                            City = "New York",
                            Country = 1,
                            CreationDate = new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7664),
                            Description = "Beautiful apartment in the heart of the city",
                            Governorate = 2,
                            Id = new Guid("7fccf48d-5601-4903-b608-d00b7d3449f2"),
                            NumOfPeople = 4,
                            PricePerNight = 100m,
                            PropType = 0
                        },
                        new
                        {
                            UserID = new Guid("2ddd6235-d265-4303-9add-65619bc0b1e6"),
                            City = "Los Angeles",
                            Country = 2,
                            CreationDate = new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7673),
                            Description = "Luxurious villa with a pool and garden",
                            Governorate = 3,
                            Id = new Guid("bf6ec124-8d8e-4c7a-8131-95bf9b504f5b"),
                            NumOfPeople = 6,
                            PricePerNight = 200m,
                            PropType = 1
                        },
                        new
                        {
                            UserID = new Guid("5c2821d2-6e03-4fd1-b304-370303e2f0d5"),
                            City = "London",
                            Country = 3,
                            CreationDate = new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7677),
                            Description = "Cozy cottage by the beach",
                            Governorate = 4,
                            Id = new Guid("3e494a77-31e9-4f56-b6e5-31bed13ebcd9"),
                            NumOfPeople = 2,
                            PricePerNight = 150m,
                            PropType = 2
                        },
                        new
                        {
                            UserID = new Guid("373ae1d0-046e-41aa-b473-7b258a91ea3d"),
                            City = "Paris",
                            Country = 4,
                            CreationDate = new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7681),
                            Description = "Cozy studio apartment in the city center",
                            Governorate = 5,
                            Id = new Guid("be04c98b-9a9a-45c3-b813-6c2f3caedd9d"),
                            NumOfPeople = 1,
                            PricePerNight = 50m,
                            PropType = 4
                        },
                        new
                        {
                            UserID = new Guid("0d7cba71-a72f-4015-b80c-62769a622628"),
                            City = "Rome",
                            Country = 5,
                            CreationDate = new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7687),
                            Description = "Wooden cabin in the woods",
                            Governorate = 6,
                            Id = new Guid("ac9060ae-a827-4925-b232-96518a6487e4"),
                            NumOfPeople = 4,
                            PricePerNight = 100m,
                            PropType = 2
                        },
                        new
                        {
                            UserID = new Guid("eec1a108-9941-443c-a35d-c3d7d6076be9"),
                            City = "Tokyo",
                            Country = 6,
                            CreationDate = new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7692),
                            Description = "Luxurious penthouse with a view",
                            Governorate = 7,
                            Id = new Guid("a1fbd31d-dba1-4cb7-8f96-25c453a42bce"),
                            NumOfPeople = 6,
                            PricePerNight = 200m,
                            PropType = 3
                        });
                });

            modelBuilder.Entity("Airbnb.DAL.PropertyAmenity", b =>
                {
                    b.Property<Guid>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AmenityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PropertyId", "AmenityId");

                    b.HasIndex("AmenityId");

                    b.ToTable("PropertyAmenities");
                });

            modelBuilder.Entity("Airbnb.DAL.PropertyRule", b =>
                {
                    b.Property<Guid>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RuleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PropertyId", "RuleId");

                    b.HasIndex("RuleId");

                    b.ToTable("PropertyRules");
                });

            modelBuilder.Entity("Airbnb.DAL.Rules", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("Airbnb.DAL.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Governorate")
                        .HasColumnType("int");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4201d29d-4239-43fb-a907-7c7ca0836c9f"),
                            City = "New York",
                            Country = 1,
                            CreationDate = new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7618),
                            Email = "john.doe@example.com",
                            FName = "John",
                            Governorate = 2,
                            LName = "Doe",
                            Password = "password123",
                            PhoneNumber = "123456789",
                            UserName = "johndoe",
                            UserRole = 0
                        },
                        new
                        {
                            Id = new Guid("2ddd6235-d265-4303-9add-65619bc0b1e6"),
                            City = "Los Angeles",
                            Country = 2,
                            CreationDate = new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7623),
                            Email = "jane.doe@example.com",
                            FName = "Jane",
                            Governorate = 3,
                            LName = "Doe",
                            Password = "password123",
                            PhoneNumber = "987654321",
                            UserName = "janedoe",
                            UserRole = 0
                        },
                        new
                        {
                            Id = new Guid("5c2821d2-6e03-4fd1-b304-370303e2f0d5"),
                            City = "London",
                            Country = 3,
                            CreationDate = new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7643),
                            Email = "michael.smith@example.com",
                            FName = "Michael",
                            Governorate = 4,
                            LName = "Smith",
                            Password = "password123",
                            PhoneNumber = "321456789",
                            UserName = "michaelsmith",
                            UserRole = 0
                        },
                        new
                        {
                            Id = new Guid("373ae1d0-046e-41aa-b473-7b258a91ea3d"),
                            City = "Paris",
                            Country = 4,
                            CreationDate = new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7647),
                            Email = "david.williams@example.com",
                            FName = "David",
                            Governorate = 5,
                            LName = "Williams",
                            Password = "password123",
                            PhoneNumber = "765432109",
                            UserName = "davidwilliams",
                            UserRole = 0
                        },
                        new
                        {
                            Id = new Guid("0d7cba71-a72f-4015-b80c-62769a622628"),
                            City = "Rome",
                            Country = 5,
                            CreationDate = new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7651),
                            Email = "elizabeth.brown@example.com",
                            FName = "Elizabeth",
                            Governorate = 6,
                            LName = "Brown",
                            Password = "password123",
                            PhoneNumber = "543210987",
                            UserName = "elizabethbrown",
                            UserRole = 1
                        },
                        new
                        {
                            Id = new Guid("eec1a108-9941-443c-a35d-c3d7d6076be9"),
                            City = "Tokyo",
                            Country = 6,
                            CreationDate = new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7657),
                            Email = "thomas.anderson@example.com",
                            FName = "Thomas",
                            Governorate = 7,
                            LName = "Anderson",
                            Password = "password123",
                            PhoneNumber = "987654321",
                            UserName = "thomasanderson",
                            UserRole = 0
                        });
                });

            modelBuilder.Entity("Airbnb.DAL.UserReserveProperty", b =>
                {
                    b.Property<Guid>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PropertyId", "CheckInDate");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Airbnb.DAL.UserReviewProperty", b =>
                {
                    b.Property<Guid>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.HasKey("PropertyId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Airbnb.DAL.Images", b =>
                {
                    b.HasOne("Airbnb.DAL.Amenity", "Amenity")
                        .WithOne("Img")
                        .HasForeignKey("Airbnb.DAL.Images", "AmenityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Airbnb.DAL.Property", "Property")
                        .WithMany("Imgs")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Airbnb.DAL.Rules", "Rule")
                        .WithOne("Img")
                        .HasForeignKey("Airbnb.DAL.Images", "RuleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Airbnb.DAL.User", "User")
                        .WithOne("Img")
                        .HasForeignKey("Airbnb.DAL.Images", "UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Amenity");

                    b.Navigation("Property");

                    b.Navigation("Rule");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Airbnb.DAL.Property", b =>
                {
                    b.HasOne("Airbnb.DAL.User", "User")
                        .WithMany("Properties")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Airbnb.DAL.PropertyAmenity", b =>
                {
                    b.HasOne("Airbnb.DAL.Amenity", "Amenity")
                        .WithMany("PropertyAmenities")
                        .HasForeignKey("AmenityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAL.Property", "Property")
                        .WithMany("PropertyAmenities")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amenity");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Airbnb.DAL.PropertyRule", b =>
                {
                    b.HasOne("Airbnb.DAL.Property", "Property")
                        .WithMany("PropertyRules")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAL.Rules", "Rule")
                        .WithMany("PropertyRules")
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("Rule");
                });

            modelBuilder.Entity("Airbnb.DAL.UserReserveProperty", b =>
                {
                    b.HasOne("Airbnb.DAL.Property", "Property")
                        .WithMany("Reservations")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAL.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Airbnb.DAL.UserReviewProperty", b =>
                {
                    b.HasOne("Airbnb.DAL.Property", "Property")
                        .WithMany("Reviews")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAL.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Airbnb.DAL.Amenity", b =>
                {
                    b.Navigation("Img");

                    b.Navigation("PropertyAmenities");
                });

            modelBuilder.Entity("Airbnb.DAL.Property", b =>
                {
                    b.Navigation("Imgs");

                    b.Navigation("PropertyAmenities");

                    b.Navigation("PropertyRules");

                    b.Navigation("Reservations");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Airbnb.DAL.Rules", b =>
                {
                    b.Navigation("Img");

                    b.Navigation("PropertyRules");
                });

            modelBuilder.Entity("Airbnb.DAL.User", b =>
                {
                    b.Navigation("Img");

                    b.Navigation("Properties");

                    b.Navigation("Reservations");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
