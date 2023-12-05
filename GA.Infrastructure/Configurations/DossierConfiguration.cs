using GA.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class DossierConfiguration : IEntityTypeConfiguration<Dossier>
    {
        public void Configure(EntityTypeBuilder<Dossier> builder)
        {
            builder.HasKey(d => new { d.AvocatFK, d.ClientFK, d.DateDepot });
            builder.HasOne(d => d.Client).WithMany(c => c.Dossiers).HasForeignKey(d => d.ClientFK);
            builder.HasOne(d => d.Avocat).WithMany(c => c.Dossiers).HasForeignKey(d => d.AvocatFK);
        }
    }
}
