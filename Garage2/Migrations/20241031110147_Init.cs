using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Garage2.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkedVehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    NumberOfWheels = table.Column<int>(type: "int", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckoutTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkedVehicle", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ParkedVehicle",
                columns: new[] { "Id", "ArrivalTime", "CheckoutTime", "Color", "Make", "Model", "NumberOfWheels", "RegistrationNumber", "VehicleType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 31, 10, 1, 46, 831, DateTimeKind.Local).AddTicks(5638), null, "Blue", "Toyota", "Corolla", 4, "ABC123", "Car" },
                    { 2, new DateTime(2024, 10, 31, 10, 1, 46, 831, DateTimeKind.Local).AddTicks(5646), null, "Green", "Hundai", "i3", 4, "ERT234", "Car" },
                    { 3, new DateTime(2024, 10, 31, 10, 1, 46, 831, DateTimeKind.Local).AddTicks(5651), null, "Balck", "BMW", "M3", 4, "ERR134", "Car" },
                    { 4, new DateTime(2024, 10, 31, 10, 1, 46, 831, DateTimeKind.Local).AddTicks(5655), null, "Red", "Honda", "Goldwing", 2, "HFF577", "Motorcycle" },
                    { 5, new DateTime(2024, 10, 31, 10, 1, 46, 831, DateTimeKind.Local).AddTicks(5660), null, "Green", "Yamaha", "R1", 2, "OOP123", "Motorcycle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkedVehicle");
        }
    }
}
