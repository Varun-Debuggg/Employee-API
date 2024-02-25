using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_1031API.Migrations
{
    public partial class addaddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Address",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "employees");
        }
    }
}
