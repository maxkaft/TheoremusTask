using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Stations
{
    public partial class postgresContext : DbContext
    {
        public postgresContext()
        {
        }

        public postgresContext(DbContextOptions<postgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GeoLocations> GeoLocations { get; set; }
        public virtual DbSet<LogicalGroups> LogicalGroups { get; set; }
        public virtual DbSet<MeasurementModuleLogicalGroup> MeasurementModuleLogicalGroup { get; set; }
        public virtual DbSet<MeasurementModulePlannedServiceCheck> MeasurementModulePlannedServiceCheck { get; set; }
        public virtual DbSet<MeasurementModuleProperty> MeasurementModuleProperty { get; set; }
        public virtual DbSet<MeasurementStationLogicalGroup> MeasurementStationLogicalGroup { get; set; }
        public virtual DbSet<MeasurementStationPlannedServiceCheck> MeasurementStationPlannedServiceCheck { get; set; }
        public virtual DbSet<MeasurementStationProperty> MeasurementStationProperty { get; set; }
        public virtual DbSet<MeasurementStationTypeProperty> MeasurementStationTypeProperty { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<Stations> Stations { get; set; }
        public virtual DbSet<StationTypes> StationTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("User ID=max;Password=1234;Host=localhost;Port=8080;Database=postgres;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("adminpack");

            modelBuilder.Entity<GeoLocations>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Annotation).IsRequired();
            });

            modelBuilder.Entity<LogicalGroups>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<MeasurementModuleLogicalGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.ModuleId });

                entity.HasIndex(e => e.ModuleId);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.MeasurementModuleLogicalGroup)
                    .HasForeignKey(d => d.GroupId);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.MeasurementModuleLogicalGroup)
                    .HasForeignKey(d => d.ModuleId);
            });

            modelBuilder.Entity<MeasurementModulePlannedServiceCheck>(entity =>
            {
                entity.HasIndex(e => e.ModuleId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.MeasurementModulePlannedServiceCheck)
                    .HasForeignKey(d => d.ModuleId);
            });

            modelBuilder.Entity<MeasurementModuleProperty>(entity =>
            {
                entity.HasKey(e => new { e.ModuleId, e.Key });

                entity.Property(e => e.ValueType).IsRequired();

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.MeasurementModuleProperty)
                    .HasForeignKey(d => d.ModuleId);
            });

            modelBuilder.Entity<MeasurementStationLogicalGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.StationId });

                entity.HasIndex(e => e.StationId);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.MeasurementStationLogicalGroup)
                    .HasForeignKey(d => d.GroupId);

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.MeasurementStationLogicalGroup)
                    .HasForeignKey(d => d.StationId);
            });

            modelBuilder.Entity<MeasurementStationPlannedServiceCheck>(entity =>
            {
                entity.HasIndex(e => e.StationId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.MeasurementStationPlannedServiceCheck)
                    .HasForeignKey(d => d.StationId);
            });

            modelBuilder.Entity<MeasurementStationProperty>(entity =>
            {
                entity.HasKey(e => new { e.StationId, e.Key });

                entity.Property(e => e.ValueType).IsRequired();

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.MeasurementStationProperty)
                    .HasForeignKey(d => d.StationId);
            });

            modelBuilder.Entity<MeasurementStationTypeProperty>(entity =>
            {
                entity.HasKey(e => new { e.StationTypeId, e.Key });

                entity.Property(e => e.ValueType).IsRequired();

                entity.HasOne(d => d.StationType)
                    .WithMany(p => p.MeasurementStationTypeProperty)
                    .HasForeignKey(d => d.StationTypeId);
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.HasIndex(e => e.ExpectedLocationId);

                entity.HasIndex(e => e.LatestLocationId);

                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.ExpectedLocation)
                    .WithMany(p => p.ModulesExpectedLocation)
                    .HasForeignKey(d => d.ExpectedLocationId);

                entity.HasOne(d => d.LatestLocation)
                    .WithMany(p => p.ModulesLatestLocation)
                    .HasForeignKey(d => d.LatestLocationId);
            });

            modelBuilder.Entity<Stations>(entity =>
            {
                entity.HasIndex(e => e.ExpectedLocationId);

                entity.HasIndex(e => e.LatestLocationId);

                entity.HasIndex(e => e.ModuleId);

                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.HasIndex(e => e.StationTypeId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.ExpectedLocation)
                    .WithMany(p => p.StationsExpectedLocation)
                    .HasForeignKey(d => d.ExpectedLocationId);

                entity.HasOne(d => d.LatestLocation)
                    .WithMany(p => p.StationsLatestLocation)
                    .HasForeignKey(d => d.LatestLocationId);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Stations)
                    .HasForeignKey(d => d.ModuleId);

                entity.HasOne(d => d.StationType)
                    .WithMany(p => p.Stations)
                    .HasForeignKey(d => d.StationTypeId);
            });

            modelBuilder.Entity<StationTypes>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Category).IsRequired();

                entity.Property(e => e.Manifacturer).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SupportedNetworkProtocolsCsv).HasColumnName("SupportedNetworkProtocolsCSV");
            });
        }
    }
}
