using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlondeBlazor.Migrations
{
    /// <inheritdoc />
    public partial class InitIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc956ef6-7ffd-4d9d-bfc9-189b2638fa30", "AQAAAAIAAYagAAAAEFTdSHAV/imUv+TZMG0KVt7hlCIB1wKb3LV2idv3/OpnsiJeGHoN4iokoeFDwLKCmA==", "cb3d9faa-fd4c-4a14-aef5-608ebdddf5ab" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(3669), new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(3687), new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(3904), new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(3907), new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(4012), new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(4013), new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(4015), new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(4016), new DateTime(2025, 12, 7, 19, 51, 16, 399, DateTimeKind.Local).AddTicks(4017) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf4daebe-aa80-48d6-8109-eedb0f46d2d6", "AQAAAAIAAYagAAAAEI/Icyo1bbrda6InfPcjECVAELDVRULQAvAPx3qgYOBOKHI5aje3c16xBDoifd0rSQ==", "d17fb120-e6b8-46a8-92e5-712d4afb20f5" });

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
        }
    }
}
