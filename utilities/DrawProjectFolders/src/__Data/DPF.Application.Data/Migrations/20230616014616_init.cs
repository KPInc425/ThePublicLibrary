using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DPF.Application.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DpfDirectories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParentId = table.Column<long>(type: "INTEGER", nullable: true),
                    FileCount = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalSizeOnDisk = table.Column<long>(type: "INTEGER", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DpfDirectories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DpfDirectories_DpfDirectories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "DpfDirectories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DpfFiles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DpfDirectoryId = table.Column<long>(type: "INTEGER", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DpfFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DpfFiles_DpfDirectories_DpfDirectoryId",
                        column: x => x.DpfDirectoryId,
                        principalTable: "DpfDirectories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DpfDirectories_ParentId",
                table: "DpfDirectories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_DpfFiles_DpfDirectoryId",
                table: "DpfFiles",
                column: "DpfDirectoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DpfFiles");

            migrationBuilder.DropTable(
                name: "DpfDirectories");
        }
    }
}
