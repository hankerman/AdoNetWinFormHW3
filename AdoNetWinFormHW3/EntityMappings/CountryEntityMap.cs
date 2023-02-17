using AdoNetWinFormHW3.Constans;
using AdoNetWinFormHW3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetWinFormHW3.EntityMappings
{
    public class CountryEntityMap : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(DatabaseDefaults.StringValueMaxLength);
            builder.HasOne(x => x.Capital)
                .WithOne()
                .HasForeignKey<Country>(c => c.CapitalId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
