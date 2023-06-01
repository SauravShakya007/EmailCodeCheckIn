using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailCodeCheckIn.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodeCheckIns",
                columns: table => new
                {
                    CodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeCheckIns", x => x.CodeId);
                });

            migrationBuilder.CreateTable(
                name: "FileURL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeCheckInCodeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileURL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileURL_CodeCheckIns_CodeCheckInCodeId",
                        column: x => x.CodeCheckInCodeId,
                        principalTable: "CodeCheckIns",
                        principalColumn: "CodeId");
                });

            migrationBuilder.CreateTable(
                name: "SendTo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeCheckInCodeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendTo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SendTo_CodeCheckIns_CodeCheckInCodeId",
                        column: x => x.CodeCheckInCodeId,
                        principalTable: "CodeCheckIns",
                        principalColumn: "CodeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileURL_CodeCheckInCodeId",
                table: "FileURL",
                column: "CodeCheckInCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_SendTo_CodeCheckInCodeId",
                table: "SendTo",
                column: "CodeCheckInCodeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileURL");

            migrationBuilder.DropTable(
                name: "SendTo");

            migrationBuilder.DropTable(
                name: "CodeCheckIns");
        }
    }
}
