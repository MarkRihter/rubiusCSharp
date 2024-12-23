using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson11.Migrations
{
    /// <inheritdoc />
    public partial class AuthorsDataBirthPlaceAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BirthPlace",
                table: "AuthorData",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthPlace",
                table: "AuthorData");
        }
    }
}
