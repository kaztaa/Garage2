using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Garage2.Migrations
{
    /// <inheritdoc />
    public partial class SeedParkedVehicleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ParkedVehicle",
                columns: new[] { "Id", "ArrivalTime", "Color", "Make", "Model", "NumberOfWheels", "RegistrationNumber", "VehicleType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 30, 8, 52, 22, 23, DateTimeKind.Local).AddTicks(1211), "Blue", "Toyota", "Corolla", 4, "ABC123", "Car" },
                    { 2, new DateTime(2024, 10, 30, 8, 52, 22, 23, DateTimeKind.Local).AddTicks(1263), "Green", "Hundai", "i3", 4, "ERT234", "Car" },
                    { 3, new DateTime(2024, 10, 30, 8, 52, 22, 23, DateTimeKind.Local).AddTicks(1300), "Balck", "BMW", "M3", 4, "ERR134", "Car" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
