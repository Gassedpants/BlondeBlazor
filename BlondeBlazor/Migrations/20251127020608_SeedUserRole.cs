using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlondeBlazor.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 6, 8, 256, DateTimeKind.Local).AddTicks(9743), new DateTime(2025, 11, 27, 10, 6, 8, 256, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 6, 8, 256, DateTimeKind.Local).AddTicks(9762), new DateTime(2025, 11, 27, 10, 6, 8, 256, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 6, 8, 256, DateTimeKind.Local).AddTicks(9948), new DateTime(2025, 11, 27, 10, 6, 8, 256, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 6, 8, 256, DateTimeKind.Local).AddTicks(9950), new DateTime(2025, 11, 27, 10, 6, 8, 256, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 6, 8, 257, DateTimeKind.Local).AddTicks(47), new DateTime(2025, 11, 27, 10, 6, 8, 257, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 6, 8, 257, DateTimeKind.Local).AddTicks(50), new DateTime(2025, 11, 27, 10, 6, 8, 257, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 6, 8, 257, DateTimeKind.Local).AddTicks(51), new DateTime(2025, 11, 27, 10, 6, 8, 257, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 6, 8, 257, DateTimeKind.Local).AddTicks(53), new DateTime(2025, 11, 27, 10, 6, 8, 257, DateTimeKind.Local).AddTicks(53) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8680), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8696), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8944), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8947), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9044), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9046), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9048), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9049), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9050) });
        }
    }
}
