using Microsoft.EntityFrameworkCore.Migrations;

namespace webapi3.Migrations
{
    public partial class webapi3ModelsAddEmployeeGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender",
                table: "Employees");
        }
    }
}
