using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityCodeFirstExamLib.Migrations
{
    /// <inheritdoc />
    public partial class addTablesToDb5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MidName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MidName",
                table: "Students");
        }
    }
}
