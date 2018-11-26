using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Stations
{
    public partial class StationsContext : DbContext
    {
        public StationsContext()
        {
        }

        public StationsContext(DbContextOptions<StationsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GeoLocations> GeoLocations { get; set; }
        public virtual DbSet<Station> Stations { get; set; }

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

            modelBuilder.Entity<Station>(entity =>
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

        }
    }
}
