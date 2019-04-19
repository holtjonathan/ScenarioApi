using Microsoft.EntityFrameworkCore.Migrations;

namespace ScenarioApi.Migrations
{
    public partial class AddMissionName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MissionName",
                table: "Missions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MissionName",
                table: "Missions");
        }
    }
}
