using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCrudBlazor.Migrations
{
    /// <inheritdoc />
    public partial class addedstatetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Employees");
        }
    }
}
