using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 3, 9, 9, 59, 24, 376, DateTimeKind.Utc).AddTicks(8237), "$2a$11$HnJK5LVy/61rl2O4dA8dVejxuLdVF2ZQCB8DHNQTC8GG3dBkI.eM." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 3, 9, 9, 52, 16, 422, DateTimeKind.Utc).AddTicks(9929), "$2a$11$hmm/Qxz3grh6FThljc0KGOZG2n9Fis/8l1fpxhzeaYtlCpmnOubFe" });
        }
    }
}
