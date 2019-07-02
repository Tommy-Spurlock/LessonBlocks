using Microsoft.EntityFrameworkCore.Migrations;

namespace DanceBlocks.Data.Migrations
{
    public partial class CompleteModelsMk1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_SkillLevelId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Steps_SkillLevelId",
                table: "Steps");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SkillLevelId",
                table: "Students",
                column: "SkillLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Steps_SkillLevelId",
                table: "Steps",
                column: "SkillLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonSteps_LessonId",
                table: "LessonSteps",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonSteps_StepId",
                table: "LessonSteps",
                column: "StepId");

            migrationBuilder.CreateIndex(
                name: "IX_DanceCategories_CategoryId",
                table: "DanceCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DanceCategories_DanceTypeId",
                table: "DanceCategories",
                column: "DanceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DanceCategories_Categories_CategoryId",
                table: "DanceCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DanceCategories_DanceTypes_DanceTypeId",
                table: "DanceCategories",
                column: "DanceTypeId",
                principalTable: "DanceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonSteps_Lessons_LessonId",
                table: "LessonSteps",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonSteps_Steps_StepId",
                table: "LessonSteps",
                column: "StepId",
                principalTable: "Steps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DanceCategories_Categories_CategoryId",
                table: "DanceCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_DanceCategories_DanceTypes_DanceTypeId",
                table: "DanceCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonSteps_Lessons_LessonId",
                table: "LessonSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonSteps_Steps_StepId",
                table: "LessonSteps");

            migrationBuilder.DropIndex(
                name: "IX_Students_SkillLevelId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Steps_SkillLevelId",
                table: "Steps");

            migrationBuilder.DropIndex(
                name: "IX_LessonSteps_LessonId",
                table: "LessonSteps");

            migrationBuilder.DropIndex(
                name: "IX_LessonSteps_StepId",
                table: "LessonSteps");

            migrationBuilder.DropIndex(
                name: "IX_DanceCategories_CategoryId",
                table: "DanceCategories");

            migrationBuilder.DropIndex(
                name: "IX_DanceCategories_DanceTypeId",
                table: "DanceCategories");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SkillLevelId",
                table: "Students",
                column: "SkillLevelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Steps_SkillLevelId",
                table: "Steps",
                column: "SkillLevelId",
                unique: true);
        }
    }
}
