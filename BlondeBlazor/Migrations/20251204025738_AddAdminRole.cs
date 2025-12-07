using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlondeBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminRole : Migration
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "bf4daebe-aa80-48d6-8109-eedb0f46d2d6", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEI/Icyo1bbrda6InfPcjECVAELDVRULQAvAPx3qgYOBOKHI5aje3c16xBDoifd0rSQ==", null, false, "d17fb120-e6b8-46a8-92e5-712d4afb20f5", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6488), new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6503), new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6729), new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6731), new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6835), new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6837), new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6839), new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6840), new DateTime(2025, 12, 4, 10, 57, 37, 740, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8680), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8696), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8944), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8947), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9044), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9046), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9048), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9049), new DateTime(2025, 11, 27, 9, 54, 50, 5, DateTimeKind.Local).AddTicks(9050) });
        }
    }
}
