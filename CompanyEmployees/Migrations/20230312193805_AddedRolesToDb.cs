using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "77c5b32c-c681-49ad-a3c9-e86d277cc832", "1630c5d1-6f77-4e5a-b274-d32834d58a3e", "Manager", "MANAGER" },
                    { "cdebc7eb-b6d4-44b7-ab66-9196cb8b6d20", "3b9920ec-fdf8-4474-8153-e4580b9c4ffc", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77c5b32c-c681-49ad-a3c9-e86d277cc832");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdebc7eb-b6d4-44b7-ab66-9196cb8b6d20");
        }
    }
}
