﻿// <auto-generated />
using System;
using Garage2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Garage2.Migrations
{
    [DbContext(typeof(Garage2Context))]
    [Migration("20241120223326_UpdateVehicleTypeTable3")]
    partial class UpdateVehicleTypeTable3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Garage2.Models.ParkedVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckoutTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("NumberOfWheels")
                        .HasColumnType("int");

                    b.Property<int?>("ParkingSpotId")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleTypesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleTypesId");

                    b.ToTable("ParkedVehicle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArrivalTime = new DateTime(2024, 11, 20, 21, 33, 25, 986, DateTimeKind.Local).AddTicks(1149),
                            Color = "Blue",
                            Make = "Toyota",
                            Model = "Corolla",
                            NumberOfWheels = 4,
                            RegistrationNumber = "ABC123",
                            VehicleTypesId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArrivalTime = new DateTime(2024, 11, 20, 21, 33, 25, 986, DateTimeKind.Local).AddTicks(1155),
                            Color = "Green",
                            Make = "Hyundai",
                            Model = "i3",
                            NumberOfWheels = 4,
                            RegistrationNumber = "ERT234",
                            VehicleTypesId = 1
                        },
                        new
                        {
                            Id = 3,
                            ArrivalTime = new DateTime(2024, 11, 20, 21, 33, 25, 986, DateTimeKind.Local).AddTicks(1160),
                            Color = "Black",
                            Make = "BMW",
                            Model = "M3",
                            NumberOfWheels = 4,
                            RegistrationNumber = "ERR134",
                            VehicleTypesId = 1
                        },
                        new
                        {
                            Id = 4,
                            ArrivalTime = new DateTime(2024, 11, 20, 21, 33, 25, 986, DateTimeKind.Local).AddTicks(1164),
                            Color = "Red",
                            Make = "Honda",
                            Model = "Goldwing",
                            NumberOfWheels = 2,
                            RegistrationNumber = "HFF577",
                            VehicleTypesId = 2
                        },
                        new
                        {
                            Id = 5,
                            ArrivalTime = new DateTime(2024, 11, 20, 21, 33, 25, 986, DateTimeKind.Local).AddTicks(1168),
                            Color = "Green",
                            Make = "Yamaha",
                            Model = "R1",
                            NumberOfWheels = 2,
                            RegistrationNumber = "OOP123",
                            VehicleTypesId = 2
                        });
                });

            modelBuilder.Entity("Garage2.Models.ParkingSpot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsOccupied")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ParkedVehicleId")
                        .HasColumnType("int");

                    b.Property<int>("SpotNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParkedVehicleId")
                        .IsUnique()
                        .HasFilter("[ParkedVehicleId] IS NOT NULL");

                    b.ToTable("ParkingSpot");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsOccupied = false,
                            SpotNumber = 1
                        },
                        new
                        {
                            Id = 2,
                            IsOccupied = false,
                            SpotNumber = 2
                        },
                        new
                        {
                            Id = 3,
                            IsOccupied = false,
                            SpotNumber = 3
                        },
                        new
                        {
                            Id = 4,
                            IsOccupied = false,
                            SpotNumber = 4
                        },
                        new
                        {
                            Id = 5,
                            IsOccupied = false,
                            SpotNumber = 5
                        },
                        new
                        {
                            Id = 6,
                            IsOccupied = false,
                            SpotNumber = 6
                        },
                        new
                        {
                            Id = 7,
                            IsOccupied = false,
                            SpotNumber = 7
                        },
                        new
                        {
                            Id = 8,
                            IsOccupied = false,
                            SpotNumber = 8
                        },
                        new
                        {
                            Id = 9,
                            IsOccupied = false,
                            SpotNumber = 9
                        },
                        new
                        {
                            Id = 10,
                            IsOccupied = false,
                            SpotNumber = 10
                        },
                        new
                        {
                            Id = 11,
                            IsOccupied = false,
                            SpotNumber = 11
                        },
                        new
                        {
                            Id = 12,
                            IsOccupied = false,
                            SpotNumber = 12
                        });
                });

            modelBuilder.Entity("Garage2.Models.VehicleTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Car"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Motorcycle"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Truck"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bus"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Van"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Bicycle"
                        });
                });

            modelBuilder.Entity("Garage2.Models.ParkedVehicle", b =>
                {
                    b.HasOne("Garage2.Models.VehicleTypes", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("Garage2.Models.ParkingSpot", b =>
                {
                    b.HasOne("Garage2.Models.ParkedVehicle", "ParkedVehicle")
                        .WithOne("ParkingSpot")
                        .HasForeignKey("Garage2.Models.ParkingSpot", "ParkedVehicleId");

                    b.Navigation("ParkedVehicle");
                });

            modelBuilder.Entity("Garage2.Models.ParkedVehicle", b =>
                {
                    b.Navigation("ParkingSpot");
                });
#pragma warning restore 612, 618
        }
    }
}