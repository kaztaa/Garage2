using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage2.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 12, 47, 55, 310, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 12, 47, 55, 310, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 12, 47, 55, 310, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "NumberOfWheels" },
                values: new object[] { new DateTime(2024, 10, 30, 12, 47, 55, 310, DateTimeKind.Local).AddTicks(3423), 2 });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "NumberOfWheels" },
                values: new object[] { new DateTime(2024, 10, 30, 12, 47, 55, 310, DateTimeKind.Local).AddTicks(3425), 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ArrivalTime", "NumberOfWheels" },
                values: new object[] { new DateTime(2024, 10, 30, 9, 2, 1, 934, DateTimeKind.Local).AddTicks(3083), 4 });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "NumberOfWheels" },
                values: new object[] { new DateTime(2024, 10, 30, 9, 2, 1, 934, DateTimeKind.Local).AddTicks(3087), 4 });
        }
    }
}
