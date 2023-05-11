using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using DAL.Classes;
using Microsoft.Data.SqlClient;

namespace DAL.Models
{
    public partial class HealthFundManagerContext : DbContext
    {
        public HealthFundManagerContext()
        {
        }

        public HealthFundManagerContext(DbContextOptions<HealthFundManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeDL> Employees { get; set; }
        public virtual DbSet<SickDL> Sicks { get; set; }
        public virtual DbSet<VaccinationDL> Vaccinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QCFGMTI\\SQLEXPRESS;Database=HealthFundManagement;Trusted_Connection=True;TrustServerCertificate=True;");
              
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeDL>(entity =>
            {
                entity.ToTable("tblEmployees");
                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName)
                    .IsRequired();

                entity.Property(e => e.Address)
                    .IsRequired();
                entity.Property(e => e.DateOfBirth).IsRequired();
                entity.Property(e => e.Phone).IsRequired().HasMaxLength(10);
                entity.Property(e => e.MobilePhone).IsRequired().HasMaxLength(10);
            });

            modelBuilder.Entity<SickDL>(entity =>
            {
                entity.ToTable("tblSicks");
                entity.Property(e => e.datePositiveResult).IsRequired();

                entity.Property(e => e.dateOfRecovery)
                    .IsRequired();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Sicks)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSicks_tblEmployees");
            });

            modelBuilder.Entity<VaccinationDL>(entity =>
            {
                entity.ToTable("tblVaccinations");

                entity.Property(e => e.DateOfVaccination).IsRequired();

                entity.Property(e => e.VaccineProducer)
                    .IsRequired();

                entity.HasOne(d => d.Employee)
                   .WithMany(p => p.Vaccinations)
                   .HasForeignKey(d => d.Id)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_tblVaccinations_tblEmployees");
            });



            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
