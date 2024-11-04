using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeToEmployment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employments_Person_PersonId",
                table: "Employments");

            migrationBuilder.DropIndex(
                name: "IX_Employments_PersonId",
                table: "Employments");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Employments");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employments_EmployeeId",
                table: "Employments",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_Person_EmployeeId",
                table: "Employments",
                column: "EmployeeId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employments_Person_EmployeeId",
                table: "Employments");

            migrationBuilder.DropIndex(
                name: "IX_Employments_EmployeeId",
                table: "Employments");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employments");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Employments",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employments_PersonId",
                table: "Employments",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_Person_PersonId",
                table: "Employments",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");
        }
    }
}
