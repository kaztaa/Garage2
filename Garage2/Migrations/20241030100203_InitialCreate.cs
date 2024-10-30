using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 9, 2, 1, 934, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 9, 2, 1, 934, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 9, 2, 1, 934, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 9, 2, 1, 934, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 9, 2, 1, 934, DateTimeKind.Local).AddTicks(3087));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 8, 59, 15, 368, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 8, 59, 15, 368, DateTimeKind.Local).AddTicks(5888));
        }
    }
}
