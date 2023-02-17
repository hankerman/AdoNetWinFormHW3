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
    public class CityEntityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(DatabaseDefaults.StringValueMaxLength);
            builder.HasOne(x => x.Country)
                .WithMany(x => x.Cities)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
