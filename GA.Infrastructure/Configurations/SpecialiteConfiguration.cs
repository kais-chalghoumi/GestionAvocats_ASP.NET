using GA.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class SpecialiteConfiguration : IEntityTypeConfiguration<Specialite>
    {
        public void Configure(EntityTypeBuilder<Specialite> builder)
        {
            builder.HasMany(d => d.Avocats).WithOne(c => c.Specialite).HasForeignKey(d => d.SpecialiteFK).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
