using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailCodeCheckIn.Migrations
{
    /// <inheritdoc />
    public partial class Initial2migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "CodeCheckIns",
                newName: "Synopsis");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Synopsis",
                table: "CodeCheckIns",
                newName: "Summary");
        }
    }
}
