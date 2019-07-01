using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DanceBlocks.Data.Migrations
{
    public partial class ChangedUserIdtostringinsteadofint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_UserId1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_UserId1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Students",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c984aa14-c5a5-4cee-9279-3a4dc3b96aea", "AQAAAAEAACcQAAAAEEJ9Etf8azyyanThpUurWGNjQ0bJETcCLPpCnOjJbZtDKLDKQBQ0GOqYXgidHPBlSw==" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 7, 1, 14, 52, 26, 242, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 7, 1, 14, 52, 26, 242, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 7, 1, 14, 52, 26, 242, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 7, 1, 14, 52, 26, 242, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "StudentStartDate", "UserId" },
                values: new object[] { new DateTime(2019, 7, 1, 14, 52, 26, 240, DateTimeKind.Local).AddTicks(1800), "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "StudentStartDate", "UserId" },
                values: new object[] { new DateTime(2019, 7, 1, 14, 52, 26, 242, DateTimeKind.Local).AddTicks(2802), "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "StudentStartDate", "UserId" },
                values: new object[] { new DateTime(2019, 7, 1, 14, 52, 26, 242, DateTimeKind.Local).AddTicks(2843), "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "StudentStartDate", "UserId" },
                values: new object[] { new DateTime(2019, 7, 1, 14, 52, 26, 242, DateTimeKind.Local).AddTicks(2851), "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_UserId",
                table: "Students",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_UserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_UserId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Students",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a00975b-f609-4a86-8fa6-e956daaaaf2e", "AQAAAAEAACcQAAAAEHU+Ogj+xILZCFt4I8gQN9/iGNG+UoaUPEFH7jXd+OmdZQX5LuK+wsTBjMOSG0GiDQ==" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 7, 1, 11, 24, 11, 25, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 7, 1, 11, 24, 11, 25, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 7, 1, 11, 24, 11, 25, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 7, 1, 11, 24, 11, 25, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "StudentStartDate", "UserId" },
                values: new object[] { new DateTime(2019, 7, 1, 11, 24, 11, 22, DateTimeKind.Local).AddTicks(8762), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "StudentStartDate", "UserId" },
                values: new object[] { new DateTime(2019, 7, 1, 11, 24, 11, 24, DateTimeKind.Local).AddTicks(8770), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "StudentStartDate", "UserId" },
                values: new object[] { new DateTime(2019, 7, 1, 11, 24, 11, 24, DateTimeKind.Local).AddTicks(8789), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "StudentStartDate", "UserId" },
                values: new object[] { new DateTime(2019, 7, 1, 11, 24, 11, 24, DateTimeKind.Local).AddTicks(8793), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId1",
                table: "Students",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_UserId1",
                table: "Students",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
