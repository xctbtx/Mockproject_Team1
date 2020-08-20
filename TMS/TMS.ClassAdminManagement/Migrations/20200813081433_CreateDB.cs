using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.ClassAdminManagement.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassAdmins",
                columns: table => new
                {
                    ClassAdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 255, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 10, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Account = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    AuditTrail = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassAdmins", x => x.ClassAdminId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassAdmins");
        }
    }
}
