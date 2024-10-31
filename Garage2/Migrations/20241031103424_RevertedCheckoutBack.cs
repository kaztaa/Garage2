using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage2.Migrations
{
    /// <inheritdoc />
    public partial class RevertedCheckoutBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "ParkedVehicle",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "ParkedVehicle",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                values: new object[] { new DateTime(2024, 10, 31, 9, 34, 24, 34, DateTimeKind.Local).AddTicks(7878), null });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "CheckoutTime" },
                values: new object[] { new DateTime(2024, 10, 31, 9, 34, 24, 34, DateTimeKind.Local).AddTicks(7885), null });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "CheckoutTime" },
                values: new object[] { new DateTime(2024, 10, 31, 9, 34, 24, 34, DateTimeKind.Local).AddTicks(7889), null });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "CheckoutTime" },
                values: new object[] { new DateTime(2024, 10, 31, 9, 34, 24, 34, DateTimeKind.Local).AddTicks(7892), null });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "CheckoutTime" },
                values: new object[] { new DateTime(2024, 10, 31, 9, 34, 24, 34, DateTimeKind.Local).AddTicks(7895), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckoutTime",
                table: "ParkedVehicle");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "ParkedVehicle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "ParkedVehicle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 31, 7, 38, 37, 953, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 31, 7, 38, 37, 953, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 31, 7, 38, 37, 953, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 31, 7, 38, 37, 953, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArrivalTime",
                value: new DateTime(2024, 10, 31, 7, 38, 37, 953, DateTimeKind.Local).AddTicks(2837));
        }
    }
}
