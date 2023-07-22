using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YmiApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_LocationRegions_RegionId",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "RegionId",
                table: "Cities",
                newName: "LocationRegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_RegionId",
                table: "Cities",
                newName: "IX_Cities_LocationRegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_LocationRegions_LocationRegionId",
                table: "Cities",
                column: "LocationRegionId",
                principalTable: "LocationRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_LocationRegions_LocationRegionId",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "LocationRegionId",
                table: "Cities",
                newName: "RegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_LocationRegionId",
                table: "Cities",
                newName: "IX_Cities_RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_LocationRegions_RegionId",
                table: "Cities",
                column: "RegionId",
                principalTable: "LocationRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
