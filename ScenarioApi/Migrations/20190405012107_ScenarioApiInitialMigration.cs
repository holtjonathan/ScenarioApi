using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScenarioApi.Migrations
{
    public partial class ScenarioApiInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
        //protected override void Up(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.CreateTable(
        //        name: "Locations",
        //        columns: table => new
        //        {
        //            LocationId = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Locations", x => x.LocationId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "MissionTypes",
        //        columns: table => new
        //        {
        //            MissionTypeId = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_MissionTypes", x => x.MissionTypeId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Rewards",
        //        columns: table => new
        //        {
        //            RewardId = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            Description = table.Column<string>(unicode: false, maxLength: 500, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Rewards", x => x.RewardId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SpecialMovesActions",
        //        columns: table => new
        //        {
        //            SpecialMoveActionID = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            ScenarioId = table.Column<int>(nullable: false),
        //            ListOrder = table.Column<int>(nullable: false),
        //            MoveText = table.Column<string>(unicode: false, maxLength: 500, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SpecialMovesActions", x => x.SpecialMoveActionID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Upgrades",
        //        columns: table => new
        //        {
        //            UpgradeId = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            Code = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
        //            Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
        //            Description = table.Column<string>(unicode: false, maxLength: 500, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Upgrades", x => x.UpgradeId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Scenarios",
        //        columns: table => new
        //        {
        //            ScenarioId = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            Slug = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
        //            LocationId = table.Column<int>(nullable: false),
        //            Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
        //            Description = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
        //            PrereqId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Scenarios", x => x.ScenarioId);
        //            table.ForeignKey(
        //                name: "FK_Scenarios_Locations",
        //                column: x => x.LocationId,
        //                principalTable: "Locations",
        //                principalColumn: "LocationId",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TribeUpgrades",
        //        columns: table => new
        //        {
        //            TribeUpgradeId = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            UpgradeId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TribeUpgrades", x => x.TribeUpgradeId);
        //            table.ForeignKey(
        //                name: "FK_TribeUpgrades_Upgrades",
        //                column: x => x.UpgradeId,
        //                principalTable: "Upgrades",
        //                principalColumn: "UpgradeId",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SpecialRules",
        //        columns: table => new
        //        {
        //            SpecialRuleId = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            ScenarioId = table.Column<int>(nullable: false),
        //            ListOrder = table.Column<int>(nullable: false),
        //            RuleText = table.Column<string>(unicode: false, maxLength: 500, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SpecialRules", x => x.SpecialRuleId);
        //            table.ForeignKey(
        //                name: "FK_SpecialRules_Scenarios",
        //                column: x => x.ScenarioId,
        //                principalTable: "Scenarios",
        //                principalColumn: "ScenarioId",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SpecialSetups",
        //        columns: table => new
        //        {
        //            SpecialSetupId = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            ScenarioId = table.Column<int>(nullable: false),
        //            ListOrder = table.Column<int>(nullable: false),
        //            SetupText = table.Column<string>(unicode: false, maxLength: 500, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SpecialSetups", x => x.SpecialSetupId);
        //            table.ForeignKey(
        //                name: "FK_SpecialSetups_Scenarios",
        //                column: x => x.ScenarioId,
        //                principalTable: "Scenarios",
        //                principalColumn: "ScenarioId",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Missions",
        //        columns: table => new
        //        {
        //            MissionId = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            ScenarioId = table.Column<int>(nullable: false),
        //            TypeId = table.Column<int>(nullable: false),
        //            Description = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
        //            RewardId = table.Column<int>(nullable: false),
        //            TribeUpgradeId = table.Column<int>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Missions", x => x.MissionId);
        //            table.ForeignKey(
        //                name: "FK_Missions_Rewards",
        //                column: x => x.RewardId,
        //                principalTable: "Rewards",
        //                principalColumn: "RewardId",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Missions_Scenarios",
        //                column: x => x.ScenarioId,
        //                principalTable: "Scenarios",
        //                principalColumn: "ScenarioId",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Missions_TribeUpgrades",
        //                column: x => x.TribeUpgradeId,
        //                principalTable: "TribeUpgrades",
        //                principalColumn: "TribeUpgradeId",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Missions_MissionTypes",
        //                column: x => x.TypeId,
        //                principalTable: "MissionTypes",
        //                principalColumn: "MissionTypeId",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Missions_RewardId",
        //        table: "Missions",
        //        column: "RewardId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Missions_ScenarioId",
        //        table: "Missions",
        //        column: "ScenarioId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Missions_TribeUpgradeId",
        //        table: "Missions",
        //        column: "TribeUpgradeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Missions_TypeId",
        //        table: "Missions",
        //        column: "TypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Scenarios_LocationId",
        //        table: "Scenarios",
        //        column: "LocationId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SpecialRules_ScenarioId",
        //        table: "SpecialRules",
        //        column: "ScenarioId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SpecialSetups_ScenarioId",
        //        table: "SpecialSetups",
        //        column: "ScenarioId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_TribeUpgrades_UpgradeId",
        //        table: "TribeUpgrades",
        //        column: "UpgradeId");
        //}

        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "Missions");

        //    migrationBuilder.DropTable(
        //        name: "SpecialMovesActions");

        //    migrationBuilder.DropTable(
        //        name: "SpecialRules");

        //    migrationBuilder.DropTable(
        //        name: "SpecialSetups");

        //    migrationBuilder.DropTable(
        //        name: "Rewards");

        //    migrationBuilder.DropTable(
        //        name: "TribeUpgrades");

        //    migrationBuilder.DropTable(
        //        name: "MissionTypes");

        //    migrationBuilder.DropTable(
        //        name: "Scenarios");

        //    migrationBuilder.DropTable(
        //        name: "Upgrades");

        //    migrationBuilder.DropTable(
        //        name: "Locations");
        //}
    }
}
