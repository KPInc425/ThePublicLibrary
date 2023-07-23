using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YmiApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Cities_CurrentCityId",
                table: "Games");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Cities_CurrentCityId",
                table: "Games",
                column: "CurrentCityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Cities_CurrentCityId",
                table: "Games");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Cities_CurrentCityId",
                table: "Games",
                column: "CurrentCityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
