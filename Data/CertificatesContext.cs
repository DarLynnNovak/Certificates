﻿
using Certificates.Models;
using Microsoft.EntityFrameworkCore;

namespace Certificates.Data
{
	public class CertificatesContext : DbContext
	{
        public CertificatesContext(DbContextOptions<CertificatesContext> options) : base(options)
        {
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<ACSPersonCME> ACSPersonCME { get; set; }
        public DbSet<ACSCertificate> ACSCertificate { get; set; }
        public DbSet<ACSCMEEvent> ACSCMEEvent { get; set; }
        public DbSet<ACSCMEEventType> ACSCMEEventType { get; set; }
        public DbSet<ACSCertificateFields> ACSCertificateFields { get; set; }

        public DbSet<ACSCMESubType> ACSCMESubType { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Person>().ToTable("Person");
			modelBuilder.Entity<ACSPersonCME>().ToTable("acspersoncme");
			modelBuilder.Entity<ACSCertificate>().ToTable("ACSCertificate");
			modelBuilder.Entity<ACSCMEEvent>().ToTable("ACSCMEEvent");
            modelBuilder.Entity<ACSCMEEventType>().ToTable("ACSCMEEventType");
            modelBuilder.Entity<ACSCertificateFields>().ToTable("ACSCertificateTemplateFields");
            modelBuilder.Entity<ACSCMESubType>().ToTable("ACSCMESubType");
        }

    }
}
