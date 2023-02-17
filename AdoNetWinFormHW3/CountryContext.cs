using AdoNetWinFormHW3.Entities;
using AdoNetWinFormHW3.EntityMappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetWinFormHW3
{
    public class CountryContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder
                .UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(CountryEntityMap).Assembly);
        }

    }
}
