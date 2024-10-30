using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage2.Migrations
{
    /// <inheritdoc />
    public partial class postmerge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 13, 12, 32, 291, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 13, 12, 32, 291, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 13, 12, 32, 291, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "NumberOfWheels" },
                values: new object[] { new DateTime(2024, 10, 30, 13, 12, 32, 291, DateTimeKind.Local).AddTicks(6503), 2 });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "NumberOfWheels" },
                values: new object[] { new DateTime(2024, 10, 30, 13, 12, 32, 291, DateTimeKind.Local).AddTicks(6507), 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 12, 16, 9, 319, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 12, 16, 9, 319, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 30, 12, 16, 9, 319, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "NumberOfWheels" },
                values: new object[] { new DateTime(2024, 10, 30, 12, 16, 9, 319, DateTimeKind.Local).AddTicks(8760), 4 });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "NumberOfWheels" },
                values: new object[] { new DateTime(2024, 10, 30, 12, 16, 9, 319, DateTimeKind.Local).AddTicks(8764), 4 });
        }
    }
}
