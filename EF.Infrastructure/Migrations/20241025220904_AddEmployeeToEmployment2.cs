using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeToEmployment2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employments_Person_EmployeeId",
                table: "Employments");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Employments",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_Person_EmployeeId",
                table: "Employments",
                column: "EmployeeId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employments_Person_EmployeeId",
                table: "Employments");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Employments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_Person_EmployeeId",
                table: "Employments",
                column: "EmployeeId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
