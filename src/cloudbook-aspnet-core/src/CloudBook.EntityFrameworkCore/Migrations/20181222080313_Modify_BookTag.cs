using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudBook.Migrations
{
    public partial class Modify_BookTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "BookTags",
                newName: "BookTags",
                newSchema: "CMS");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "CMS",
                table: "BookTags",
                maxLength: 65,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "BookTags",
                schema: "CMS",
                newName: "BookTags");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BookTags",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 65,
                oldNullable: true);
        }
    }
}
