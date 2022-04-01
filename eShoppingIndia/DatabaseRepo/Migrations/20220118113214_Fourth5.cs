using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Fourth5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                 table: "Roles",
                 columns: new[] { "RoleId", "CreatedDate", "Description", "Name", "UpdatedDate" },
                 values: new object[] { 1, new DateTime(2022, 1, 18, 16, 38, 59, 791, DateTimeKind.Local).AddTicks(1834), "Admin", "Admin", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] {"RoleId" ,"UserId", "Address", "CreatedDate", "Name", "Password", "UpdatedDate", "UserName", "contactno" },
                values: new object[] { 1,1, "F-76, gsgsg", new DateTime(2022, 1, 18, 16, 38, 59, 786, DateTimeKind.Local).AddTicks(7508), "Pragati", "Lotus@2005", null, "9868948801", "9868948801" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 18, 16, 58, 38, 814, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 18, 16, 58, 38, 817, DateTimeKind.Local).AddTicks(6259));
        }
    }
}
