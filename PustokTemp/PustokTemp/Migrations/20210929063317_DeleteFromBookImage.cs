using Microsoft.EntityFrameworkCore.Migrations;

namespace PustokTemp.Migrations
{
    public partial class DeleteFromBookImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoverImage",
                table: "BookImages");

            migrationBuilder.DropColumn(
                name: "HoverPosterStatus",
                table: "BookImages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HoverImage",
                table: "BookImages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HoverPosterStatus",
                table: "BookImages",
                type: "bit",
                nullable: true);
        }
    }
}
