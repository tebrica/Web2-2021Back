using Backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Ekipa> Ekipe { get; set; }
        public DbSet<Element> Elementi { get; set; }
        public DbSet<NalogRada> NaloziRada { get; set; }
        public DbSet<PlanRada> PlanoviRada { get; set; }
        public DbSet<Poruka> Poruke { get; set; }
        public DbSet<Potrosac> Potrosaci { get; set; }
        public DbSet<Poziv> Pozivi { get; set; }
        public DbSet<Resolution> Resolutions { get; set; }
        public DbSet<SafetyDocument> SafetyDocuments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
