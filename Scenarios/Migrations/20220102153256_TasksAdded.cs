using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scenarios.Migrations
{
    public partial class TasksAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "IsCompleted", "Text" },
                values: new object[] { 1, false, "Go shopping" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "IsCompleted", "Text" },
                values: new object[] { 2, true, "Walk the dog" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
