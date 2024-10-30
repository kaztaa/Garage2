using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Garage2.Migrations
{
    /// <inheritdoc />
    public partial class AddAdditionalParkedVehicleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 8, 59, 15, 368, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 8, 59, 15, 368, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 8, 59, 15, 368, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.InsertData(
                table: "ParkedVehicle",
                columns: new[] { "Id", "ArrivalTime", "Color", "Make", "Model", "NumberOfWheels", "RegistrationNumber", "VehicleType" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 10, 30, 8, 59, 15, 368, DateTimeKind.Local).AddTicks(5885), "Red", "Honda", "Goldwing", 4, "HFF577", "Motorcycle" },
                    { 5, new DateTime(2024, 10, 30, 8, 59, 15, 368, DateTimeKind.Local).AddTicks(5888), "Green", "Yamaha", "R1", 4, "OOP123", "Motorcycle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 8, 52, 22, 23, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 8, 52, 22, 23, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 8, 52, 22, 23, DateTimeKind.Local).AddTicks(1300));
        }
    }
}
