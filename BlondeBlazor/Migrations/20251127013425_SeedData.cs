using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlondeBlazor.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(5690), new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(5703), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(5706), new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(5707), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(5944), new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(5944), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(5946), new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(5946), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(6031), new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(6032), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(6033), new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(6033), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(6035), new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(6035), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(6036), new DateTime(2025, 11, 27, 9, 34, 24, 467, DateTimeKind.Local).AddTicks(6037), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
