namespace WebApplication8.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Student : DbContext
    {
        public Student()
            : base("name=Student")
        {
        }

        public virtual DbSet<studInfo> studInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<studInfo>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.MotherTongue)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.Religion)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.Caste)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.subCaste)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.BirthPlace)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.DateOfBirth)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.DateOfBirthInWords)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.PrevSchoolName)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.AdmittedInClass)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.AdmissionDate)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.Progress)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.Behaviour)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.DateOfSchoolLeaving)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.ClassFromLeft)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.CertRecDate)
                .IsUnicode(false);

            modelBuilder.Entity<studInfo>()
                .Property(e => e.ReceivedBy)
                .IsUnicode(false);
        }
    }
}
