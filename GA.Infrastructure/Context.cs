using Data.Configurations;
using GA.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class Context: DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Avocat> Avocats { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<Dossier> Dossiers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source= (localdb)\MSSQLLOCALDB; INITIAL CATALOG= NomPrenom; INTEGRATED SECURITY= TRUE")
                .UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DossierConfiguration());
            modelBuilder.ApplyConfiguration(new SpecialiteConfiguration());
        }
    }
}
