using Microsoft.EntityFrameworkCore.Migrations;

namespace DanceBlocks.Data.Migrations
{
    public partial class CompleteModelsMk11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_DanceTypeId",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DanceTypeId",
                table: "Students",
                column: "DanceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_DanceTypeId",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DanceTypeId",
                table: "Students",
                column: "DanceTypeId",
                unique: true);
        }
    }
}
