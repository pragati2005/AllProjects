using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Nextmig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 1, 21, 17, 4, 22, 484, DateTimeKind.Local).AddTicks(7312), "User", "User", null });
        }
    }
}
