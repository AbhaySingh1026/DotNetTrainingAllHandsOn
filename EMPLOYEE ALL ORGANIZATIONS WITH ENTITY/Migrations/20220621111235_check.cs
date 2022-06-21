using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMPLOYEE_ALL_ORGANIZATIONS_WITH_ENTITY.Migrations
{
    public partial class check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employeeOrganizations_employees_EmployeeID",
                table: "employeeOrganizations");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "employeeOrganizations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_employeeOrganizations_employees_EmployeeID",
                table: "employeeOrganizations",
                column: "EmployeeID",
                principalTable: "employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employeeOrganizations_employees_EmployeeID",
                table: "employeeOrganizations");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "employeeOrganizations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_employeeOrganizations_employees_EmployeeID",
                table: "employeeOrganizations",
                column: "EmployeeID",
                principalTable: "employees",
                principalColumn: "EmployeeID");
        }
    }
}
