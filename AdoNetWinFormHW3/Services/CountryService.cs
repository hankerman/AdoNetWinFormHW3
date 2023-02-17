using AdoNetWinFormHW3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetWinFormHW3.Services
{
    public class CountryService
    {
        private readonly CountryContext _context;
        public CountryService()
        {
            _context = new CountryContext();
        }
        public async Task<List<Country>> GetCountry()
        {
            return await _context.Countries.ToListAsync();
        }
    }
}
