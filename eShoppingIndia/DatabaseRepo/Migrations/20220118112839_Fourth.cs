using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Roles");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Roles",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
            migrationBuilder.InsertData(
               table: "Roles",
               columns: new[] { "RoleId", "CreatedDate", "Description", "Name", "UpdatedDate" },
               values: new object[] { 1, new DateTime(2022, 1, 18, 16, 38, 59, 791, DateTimeKind.Local).AddTicks(1834), "Admin", "Admin", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "CreatedDate", "Name", "Password", "UpdatedDate", "UserName", "contactno" ,"RoleId"},
                values: new object[] { 1, "F-76, gsgsg", new DateTime(2022, 1, 18, 16, 38, 59, 786, DateTimeKind.Local).AddTicks(7508), "Pragati", "Lotus@2005", null, "9868948801", "9868948801" ,1});

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "RoleId",
            //    keyValue: 1,
            //    column: "CreatedDate",
            //    value: new DateTime(2022, 1, 18, 16, 58, 38, 814, DateTimeKind.Local).AddTicks(5826));

            //migrationBuilder.UpdateData(
            //    table: "Users",
            //    keyColumn: "UserId",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "Name" },
            //    values: new object[] { new DateTime(2022, 1, 18, 16, 58, 38, 817, DateTimeKind.Local).AddTicks(6259), "Pragati" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Roles",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2022, 1, 18, 16, 55, 42, 383, DateTimeKind.Local).AddTicks(8922), "1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 1, 18, 16, 55, 42, 378, DateTimeKind.Local).AddTicks(4742), "Prag" });
        }
    }
}
