using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlondeBlazor.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTypeMakeandModelId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ModelId",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f97387b7-a542-4374-80fd-fe6626c65d77", "AQAAAAIAAYagAAAAEP/HSpPdKwYPfpMQ9uVGF2iGanSiuhlnzB1DtQOUCJrIxwaFqagcOtIfp3E4rRVqtw==", "1b78f1a5-255d-45c7-95ff-0e9afc58e1f7" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7360), new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7376), new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7605), new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7607), new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7716), new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7718), new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7720), new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7721), new DateTime(2025, 12, 7, 21, 2, 50, 650, DateTimeKind.Local).AddTicks(7722) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModelId",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MakeId",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
