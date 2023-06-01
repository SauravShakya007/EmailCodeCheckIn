using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailCodeCheckIn.Migrations
{
    /// <inheritdoc />
    public partial class check : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeploymentDocument",
                table: "CodeCheckIns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImpactAnalysis",
                table: "CodeCheckIns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UnitTest",
                table: "CodeCheckIns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeploymentDocument",
                table: "CodeCheckIns");

            migrationBuilder.DropColumn(
                name: "ImpactAnalysis",
                table: "CodeCheckIns");

            migrationBuilder.DropColumn(
                name: "UnitTest",
                table: "CodeCheckIns");
        }
    }
}
