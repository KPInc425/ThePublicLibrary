using Microsoft.EntityFrameworkCore.Migrations;

namespace Langwish.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FolderWatchers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FolderName = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    FoundModulesCt = table.Column<long>(type: "INTEGER", nullable: false),
                    FoundEntriesCt = table.Column<long>(type: "INTEGER", nullable: false),
                    FoundEntriesUniqueCt = table.Column<long>(type: "INTEGER", nullable: false),
                    ProjectRootPath = table.Column<string>(type: "TEXT", maxLength: 800, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolderWatchers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LangwishRuns",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RunDuration = table.Column<string>(type: "TEXT", nullable: true),
                    FilesFoundCt = table.Column<long>(type: "INTEGER", nullable: false),
                    FoldersFoundCt = table.Column<long>(type: "INTEGER", nullable: false),
                    TranslatesFoundCt = table.Column<long>(type: "INTEGER", nullable: false),
                    TranslatesFoundUniqueCt = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LangwishRuns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LangwishWords",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TranslateText = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LangwishWords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileWatchers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FolderWatcherId = table.Column<long>(type: "INTEGER", nullable: false),
                    FileName = table.Column<string>(type: "TEXT", nullable: true),
                    FileNameWithoutExtension = table.Column<string>(type: "TEXT", nullable: true),
                    FileNameWithFullPath = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileWatchers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileWatchers_FolderWatchers_FolderWatcherId",
                        column: x => x.FolderWatcherId,
                        principalTable: "FolderWatchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LangwishWordInFiles",
                columns: table => new
                {
                    LangwishWordId = table.Column<long>(type: "INTEGER", nullable: false),
                    FileWatcherId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LangwishWordInFiles", x => new { x.LangwishWordId, x.FileWatcherId });
                    table.ForeignKey(
                        name: "FK_LangwishWordInFiles_FileWatchers_FileWatcherId",
                        column: x => x.FileWatcherId,
                        principalTable: "FileWatchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LangwishWordInFiles_LangwishWords_LangwishWordId",
                        column: x => x.LangwishWordId,
                        principalTable: "LangwishWords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileWatchers_FolderWatcherId",
                table: "FileWatchers",
                column: "FolderWatcherId");

            migrationBuilder.CreateIndex(
                name: "IX_LangwishWordInFiles_FileWatcherId",
                table: "LangwishWordInFiles",
                column: "FileWatcherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LangwishRuns");

            migrationBuilder.DropTable(
                name: "LangwishWordInFiles");

            migrationBuilder.DropTable(
                name: "FileWatchers");

            migrationBuilder.DropTable(
                name: "LangwishWords");

            migrationBuilder.DropTable(
                name: "FolderWatchers");
        }
    }
}
