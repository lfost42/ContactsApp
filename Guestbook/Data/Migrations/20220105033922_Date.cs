using Microsoft.EntityFrameworkCore.Migrations;

namespace Guestbook.Data.Migrations
{
    public partial class Date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(name: "BirthDate", table: "Contacts", newName: "Date", schema: "public");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(name: "Date", table: "Contacts", newName: "BirthDate", schema: "public");
        }
    }
}