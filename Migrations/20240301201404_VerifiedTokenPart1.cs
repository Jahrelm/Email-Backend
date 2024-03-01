using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace emailmanager.Migrations
{
    /// <inheritdoc />
    public partial class VerifiedTokenPart1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VerifiedToken",
                table: "Users",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VerifiedToken",
                table: "Users");
        }
    }
}
