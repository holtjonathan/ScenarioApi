using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScenarioApi.Models
{
    public partial class ScenarioContext : DbContext
    {
        public ScenarioContext()
        {
        }

        public ScenarioContext(DbContextOptions<ScenarioContext> options)
            : base(options)
        {
           // Database.Migrate();
        }

        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<MissionTypes> MissionTypes { get; set; }
        public virtual DbSet<Missions> Missions { get; set; }
        public virtual DbSet<Rewards> Rewards { get; set; }
        public virtual DbSet<Scenarios> Scenarios { get; set; }
        public virtual DbSet<SpecialMovesActions> SpecialMovesActions { get; set; }
        public virtual DbSet<SpecialRules> SpecialRules { get; set; }
        public virtual DbSet<SpecialSetups> SpecialSetups { get; set; }
        public virtual DbSet<TribeUpgrades> TribeUpgrades { get; set; }
        public virtual DbSet<Upgrades> Upgrades { get; set; }
        public virtual DbSet<LocationSelectionTracking> LocationSelectionTracking { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:hate.database.windows.net,1433;Initial Catalog=Scenario;Persist Security Info=False;User ID=adminlogin;Password=Spears00;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<LocationSelectionTracking>(entity =>
            {
                entity.HasKey(e => e.LocationSelectionTrackingId);

                entity.Property(e => e.ScenarioId)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MissionTypes>(entity =>
            {
                entity.HasKey(e => e.MissionTypeId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Missions>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Reward)
                    .WithMany(p => p.Missions)
                    .HasForeignKey(d => d.RewardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Missions_Rewards");

                entity.HasOne(d => d.Scenario)
                    .WithMany(p => p.Missions)
                    .HasForeignKey(d => d.ScenarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Missions_Scenarios");

                entity.HasOne(d => d.TribeUpgrade)
                    .WithMany(p => p.Missions)
                    .HasForeignKey(d => d.TribeUpgradeId)
                    .HasConstraintName("FK_Missions_TribeUpgrades");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Missions)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Missions_MissionTypes");
            });

            modelBuilder.Entity<Rewards>(entity =>
            {
                entity.HasKey(e => e.RewardId);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Scenarios>(entity =>
            {
                entity.HasKey(e => e.ScenarioId);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Scenarios)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Scenarios_Locations");
            });

            modelBuilder.Entity<SpecialMovesActions>(entity =>
            {
                entity.HasKey(e => e.SpecialMoveActionId);

                entity.Property(e => e.SpecialMoveActionId).HasColumnName("SpecialMoveActionID");

                entity.Property(e => e.MoveText)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpecialRules>(entity =>
            {
                entity.HasKey(e => e.SpecialRuleId);

                entity.Property(e => e.RuleText)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Scenario)
                    .WithMany(p => p.SpecialRules)
                    .HasForeignKey(d => d.ScenarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpecialRules_Scenarios");
            });

            modelBuilder.Entity<SpecialSetups>(entity =>
            {
                entity.HasKey(e => e.SpecialSetupId);

                entity.Property(e => e.SetupText)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Scenario)
                    .WithMany(p => p.SpecialSetups)
                    .HasForeignKey(d => d.ScenarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpecialSetups_Scenarios");
            });

            modelBuilder.Entity<TribeUpgrades>(entity =>
            {
                entity.HasKey(e => e.TribeUpgradeId);

                entity.HasOne(d => d.Upgrade)
                    .WithMany(p => p.TribeUpgrades)
                    .HasForeignKey(d => d.UpgradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TribeUpgrades_Upgrades");
            });

            modelBuilder.Entity<Upgrades>(entity =>
            {
                entity.HasKey(e => e.UpgradeId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
