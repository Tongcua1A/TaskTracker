using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskTracker.Migrations
{
    /// <inheritdoc />
    public partial class InitAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TaskItems",
                type: "longtext",
                nullable: true);


            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "TaskItems",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Priority",
                table: "TaskItems",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "TaskItems",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TaskItems",
                newName: "Title");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "TaskItems",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
