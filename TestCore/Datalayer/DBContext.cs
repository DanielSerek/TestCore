using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using TestCore.Models;

namespace TestCore.Datalayer
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CisAgendaSablona> AgendaSablonas { get; set; }
        public virtual DbSet<CisAgenda> Agendas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.Development.json")
                    .Build();
                var connectionString = configuration.GetSection("AppConfig:DB").Value;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CisAgendaSablona>(entity =>
            {
                entity.HasOne(d => d.GidProjektNavigation)
                    .WithMany(p => p.AgendaSablonas)
                    .HasForeignKey(d => d.GidProjekt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENDA_SABLONA_AGENDA");
            });

            modelBuilder.Entity<CisAgenda>(entity =>
            {
                entity.HasKey(e => e.GidProjekt)
                    .HasName("PK_AGENDA_1");

                entity.Property(e => e.GidProjekt).ValueGeneratedNever();
            });
            
            OnModelCreatingPartial(modelBuilder);
        }
   
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
