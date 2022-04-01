using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class sixth1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 18, 18, 41, 44, 577, DateTimeKind.Local).AddTicks(7995));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 18, 18, 40, 35, 675, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 1, 18, 18, 40, 35, 672, DateTimeKind.Local).AddTicks(6129), "Admin", "Admin", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "CreatedDate", "Name", "Password", "RoleId", "UpdatedDate", "UserName", "contactno" },
                values: new object[] { 1, "F-76, gsgsg", new DateTime(2022, 1, 18, 18, 40, 35, 675, DateTimeKind.Local).AddTicks(9725), "Pragati", "Lotus@2005", 1, null, "9868948801", "9868948801" });
        }
    }
}
