using Microsoft.EntityFrameworkCore.Migrations;

namespace ScenarioApi.Migrations
{
    public partial class ScenariosAddTestName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TestName",
                table: "Scenarios",
                maxLength: 25,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestName",
                table: "Scenarios");
        }
    }
}
