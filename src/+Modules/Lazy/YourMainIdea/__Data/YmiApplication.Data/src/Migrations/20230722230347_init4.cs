using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YmiApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_LocationRegions_LocationRegionId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_LocationRegionId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "LocationRegionId",
                table: "Cities");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_LocationRegions_Id",
                table: "Cities",
                column: "Id",
                principalTable: "LocationRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_LocationRegions_Id",
                table: "Cities");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationRegionId",
                table: "Cities",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Cities_LocationRegionId",
                table: "Cities",
                column: "LocationRegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_LocationRegions_LocationRegionId",
                table: "Cities",
                column: "LocationRegionId",
                principalTable: "LocationRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
