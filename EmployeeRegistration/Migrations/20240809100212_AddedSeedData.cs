using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeRegistration.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Qualifications",
                columns: new[] { "Q_Id", "Q_Name" },
                values: new object[,]
                {
                    { 1, "SLC" },
                    { 2, "Intermediate" },
                    { 3, "BE" },
                    { 4, "ME" },
                    { 5, "PHD" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "Q_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "Q_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "Q_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "Q_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Qualifications",
                keyColumn: "Q_Id",
                keyValue: 5);
        }
    }
}
