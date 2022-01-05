using Microsoft.EntityFrameworkCore.Migrations;

namespace Guestbook.Data.Migrations
{
    public partial class RenameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(name: "Contacts", schema: "public", newName: "Guests", newSchema: "public");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(name: "Guests", schema: "dbo", newName: "Contacts", newSchema: "public");
        }
    }
}