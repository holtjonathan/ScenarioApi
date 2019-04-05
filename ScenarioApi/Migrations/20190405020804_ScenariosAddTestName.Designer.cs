﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScenarioApi.Models;

namespace ScenarioApi.Migrations
{
    [DbContext(typeof(ScenarioContext))]
    [Migration("20190405020804_ScenariosAddTestName")]
    partial class ScenariosAddTestName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScenarioApi.Models.Locations", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("ScenarioApi.Models.MissionTypes", b =>
                {
                    b.Property<int>("MissionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("MissionTypeId");

                    b.ToTable("MissionTypes");
                });

            modelBuilder.Entity("ScenarioApi.Models.Missions", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<int>("RewardId");

                    b.Property<int>("ScenarioId");

                    b.Property<int?>("TribeUpgradeId");

                    b.Property<int>("TypeId");

                    b.HasKey("MissionId");

                    b.HasIndex("RewardId");

                    b.HasIndex("ScenarioId");

                    b.HasIndex("TribeUpgradeId");

                    b.HasIndex("TypeId");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("ScenarioApi.Models.Rewards", b =>
                {
                    b.Property<int>("RewardId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.HasKey("RewardId");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("ScenarioApi.Models.Scenarios", b =>
                {
                    b.Property<int>("ScenarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<int>("LocationId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<int>("PrereqId");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("TestName")
                        .HasMaxLength(25);

                    b.HasKey("ScenarioId");

                    b.HasIndex("LocationId");

                    b.ToTable("Scenarios");
                });

            modelBuilder.Entity("ScenarioApi.Models.SpecialMovesActions", b =>
                {
                    b.Property<int>("SpecialMoveActionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SpecialMoveActionID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ListOrder");

                    b.Property<string>("MoveText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<int>("ScenarioId");

                    b.HasKey("SpecialMoveActionId");

                    b.ToTable("SpecialMovesActions");
                });

            modelBuilder.Entity("ScenarioApi.Models.SpecialRules", b =>
                {
                    b.Property<int>("SpecialRuleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ListOrder");

                    b.Property<string>("RuleText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<int>("ScenarioId");

                    b.HasKey("SpecialRuleId");

                    b.HasIndex("ScenarioId");

                    b.ToTable("SpecialRules");
                });

            modelBuilder.Entity("ScenarioApi.Models.SpecialSetups", b =>
                {
                    b.Property<int>("SpecialSetupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ListOrder");

                    b.Property<int>("ScenarioId");

                    b.Property<string>("SetupText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.HasKey("SpecialSetupId");

                    b.HasIndex("ScenarioId");

                    b.ToTable("SpecialSetups");
                });

            modelBuilder.Entity("ScenarioApi.Models.TribeUpgrades", b =>
                {
                    b.Property<int>("TribeUpgradeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UpgradeId");

                    b.HasKey("TribeUpgradeId");

                    b.HasIndex("UpgradeId");

                    b.ToTable("TribeUpgrades");
                });

            modelBuilder.Entity("ScenarioApi.Models.Upgrades", b =>
                {
                    b.Property<int>("UpgradeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("UpgradeId");

                    b.ToTable("Upgrades");
                });

            modelBuilder.Entity("ScenarioApi.Models.Missions", b =>
                {
                    b.HasOne("ScenarioApi.Models.Rewards", "Reward")
                        .WithMany("Missions")
                        .HasForeignKey("RewardId")
                        .HasConstraintName("FK_Missions_Rewards");

                    b.HasOne("ScenarioApi.Models.Scenarios", "Scenario")
                        .WithMany("Missions")
                        .HasForeignKey("ScenarioId")
                        .HasConstraintName("FK_Missions_Scenarios");

                    b.HasOne("ScenarioApi.Models.TribeUpgrades", "TribeUpgrade")
                        .WithMany("Missions")
                        .HasForeignKey("TribeUpgradeId")
                        .HasConstraintName("FK_Missions_TribeUpgrades");

                    b.HasOne("ScenarioApi.Models.MissionTypes", "Type")
                        .WithMany("Missions")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK_Missions_MissionTypes");
                });

            modelBuilder.Entity("ScenarioApi.Models.Scenarios", b =>
                {
                    b.HasOne("ScenarioApi.Models.Locations", "Location")
                        .WithMany("Scenarios")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("FK_Scenarios_Locations");
                });

            modelBuilder.Entity("ScenarioApi.Models.SpecialRules", b =>
                {
                    b.HasOne("ScenarioApi.Models.Scenarios", "Scenario")
                        .WithMany("SpecialRules")
                        .HasForeignKey("ScenarioId")
                        .HasConstraintName("FK_SpecialRules_Scenarios");
                });

            modelBuilder.Entity("ScenarioApi.Models.SpecialSetups", b =>
                {
                    b.HasOne("ScenarioApi.Models.Scenarios", "Scenario")
                        .WithMany("SpecialSetups")
                        .HasForeignKey("ScenarioId")
                        .HasConstraintName("FK_SpecialSetups_Scenarios");
                });

            modelBuilder.Entity("ScenarioApi.Models.TribeUpgrades", b =>
                {
                    b.HasOne("ScenarioApi.Models.Upgrades", "Upgrade")
                        .WithMany("TribeUpgrades")
                        .HasForeignKey("UpgradeId")
                        .HasConstraintName("FK_TribeUpgrades_Upgrades");
                });
#pragma warning restore 612, 618
        }
    }
}
