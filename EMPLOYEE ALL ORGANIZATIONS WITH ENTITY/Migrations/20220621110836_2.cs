using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMPLOYEE_ALL_ORGANIZATIONS_WITH_ENTITY.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employeeOrganizations_employees_EmployeeID",
                table: "employeeOrganizations");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "employeeOrganizations",
                newName: "EmployeeEmployeeIDEmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_employeeOrganizations_EmployeeID",
                table: "employeeOrganizations",
                newName: "IX_employeeOrganizations_EmployeeEmployeeIDEmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_employeeOrganizations_employees_EmployeeEmployeeIDEmployeeID",
                table: "employeeOrganizations",
                column: "EmployeeEmployeeIDEmployeeID",
                principalTable: "employees",
                principalColumn: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employeeOrganizations_employees_EmployeeEmployeeIDEmployeeID",
                table: "employeeOrganizations");

            migrationBuilder.RenameColumn(
                name: "EmployeeEmployeeIDEmployeeID",
                table: "employeeOrganizations",
                newName: "EmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_employeeOrganizations_EmployeeEmployeeIDEmployeeID",
                table: "employeeOrganizations",
                newName: "IX_employeeOrganizations_EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_employeeOrganizations_employees_EmployeeID",
                table: "employeeOrganizations",
                column: "EmployeeID",
                principalTable: "employees",
                principalColumn: "EmployeeID");
        }
    }
}
