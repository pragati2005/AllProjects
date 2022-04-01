using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 18, 18, 40, 35, 672, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 1, 18, 18, 40, 35, 675, DateTimeKind.Local).AddTicks(7855), "User", "User", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 18, 18, 40, 35, 675, DateTimeKind.Local).AddTicks(9725));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 18, 18, 34, 28, 759, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 18, 18, 34, 28, 768, DateTimeKind.Local).AddTicks(8600));
        }
    }
}
