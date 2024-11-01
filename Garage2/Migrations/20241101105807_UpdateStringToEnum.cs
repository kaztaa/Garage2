using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStringToEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VehicleType",
                table: "ParkedVehicle",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2024, 11, 1, 9, 58, 7, 269, DateTimeKind.Local).AddTicks(2662), 0 });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2024, 11, 1, 9, 58, 7, 269, DateTimeKind.Local).AddTicks(2669), 0 });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2024, 11, 1, 9, 58, 7, 269, DateTimeKind.Local).AddTicks(2672), 0 });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2024, 11, 1, 9, 58, 7, 269, DateTimeKind.Local).AddTicks(2676), 1 });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2024, 11, 1, 9, 58, 7, 269, DateTimeKind.Local).AddTicks(2679), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleType",
                table: "ParkedVehicle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2024, 10, 31, 9, 34, 24, 34, DateTimeKind.Local).AddTicks(7878), "Car" });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2024, 10, 31, 9, 34, 24, 34, DateTimeKind.Local).AddTicks(7885), "Car" });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2024, 10, 31, 9, 34, 24, 34, DateTimeKind.Local).AddTicks(7889), "Car" });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2024, 10, 31, 9, 34, 24, 34, DateTimeKind.Local).AddTicks(7892), "Motorcycle" });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2024, 10, 31, 9, 34, 24, 34, DateTimeKind.Local).AddTicks(7895), "Motorcycle" });
        }
    }
}
