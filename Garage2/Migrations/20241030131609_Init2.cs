using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage2.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CheckoutTime",
                table: "ParkedVehicle",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "CheckoutTime" },
                values: new object[] { new DateTime(2024, 10, 30, 12, 16, 9, 319, DateTimeKind.Local).AddTicks(8746), null });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "CheckoutTime" },
                values: new object[] { new DateTime(2024, 10, 30, 12, 16, 9, 319, DateTimeKind.Local).AddTicks(8752), null });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "CheckoutTime" },
                values: new object[] { new DateTime(2024, 10, 30, 12, 16, 9, 319, DateTimeKind.Local).AddTicks(8756), null });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "CheckoutTime" },
                values: new object[] { new DateTime(2024, 10, 30, 12, 16, 9, 319, DateTimeKind.Local).AddTicks(8760), null });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "CheckoutTime" },
                values: new object[] { new DateTime(2024, 10, 30, 12, 16, 9, 319, DateTimeKind.Local).AddTicks(8764), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckoutTime",
                table: "ParkedVehicle");

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
    }
}
