using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyNameToEmployment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Employments",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "Employments");
        }
    }
}
