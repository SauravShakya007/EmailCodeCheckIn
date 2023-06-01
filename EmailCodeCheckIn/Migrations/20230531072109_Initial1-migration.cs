using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailCodeCheckIn.Migrations
{
    /// <inheritdoc />
    public partial class Initial1migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileURL_CodeCheckIns_CodeCheckInCodeId",
                table: "FileURL");

            migrationBuilder.DropForeignKey(
                name: "FK_SendTo_CodeCheckIns_CodeCheckInCodeId",
                table: "SendTo");

            migrationBuilder.DropIndex(
                name: "IX_SendTo_CodeCheckInCodeId",
                table: "SendTo");

            migrationBuilder.DropIndex(
                name: "IX_FileURL_CodeCheckInCodeId",
                table: "FileURL");

            migrationBuilder.DropColumn(
                name: "CodeCheckInCodeId",
                table: "SendTo");

            migrationBuilder.DropColumn(
                name: "CodeCheckInCodeId",
                table: "FileURL");

            migrationBuilder.AddColumn<int>(
                name: "CodeCheckInId",
                table: "SendTo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodeCheckInId",
                table: "FileURL",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "CodeCheckIns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SendTo_CodeCheckInId",
                table: "SendTo",
                column: "CodeCheckInId");

            migrationBuilder.CreateIndex(
                name: "IX_FileURL_CodeCheckInId",
                table: "FileURL",
                column: "CodeCheckInId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileURL_CodeCheckIns_CodeCheckInId",
                table: "FileURL",
                column: "CodeCheckInId",
                principalTable: "CodeCheckIns",
                principalColumn: "CodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SendTo_CodeCheckIns_CodeCheckInId",
                table: "SendTo",
                column: "CodeCheckInId",
                principalTable: "CodeCheckIns",
                principalColumn: "CodeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileURL_CodeCheckIns_CodeCheckInId",
                table: "FileURL");

            migrationBuilder.DropForeignKey(
                name: "FK_SendTo_CodeCheckIns_CodeCheckInId",
                table: "SendTo");

            migrationBuilder.DropIndex(
                name: "IX_SendTo_CodeCheckInId",
                table: "SendTo");

            migrationBuilder.DropIndex(
                name: "IX_FileURL_CodeCheckInId",
                table: "FileURL");

            migrationBuilder.DropColumn(
                name: "CodeCheckInId",
                table: "SendTo");

            migrationBuilder.DropColumn(
                name: "CodeCheckInId",
                table: "FileURL");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "CodeCheckIns");

            migrationBuilder.AddColumn<int>(
                name: "CodeCheckInCodeId",
                table: "SendTo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodeCheckInCodeId",
                table: "FileURL",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SendTo_CodeCheckInCodeId",
                table: "SendTo",
                column: "CodeCheckInCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_FileURL_CodeCheckInCodeId",
                table: "FileURL",
                column: "CodeCheckInCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileURL_CodeCheckIns_CodeCheckInCodeId",
                table: "FileURL",
                column: "CodeCheckInCodeId",
                principalTable: "CodeCheckIns",
                principalColumn: "CodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SendTo_CodeCheckIns_CodeCheckInCodeId",
                table: "SendTo",
                column: "CodeCheckInCodeId",
                principalTable: "CodeCheckIns",
                principalColumn: "CodeId");
        }
    }
}
