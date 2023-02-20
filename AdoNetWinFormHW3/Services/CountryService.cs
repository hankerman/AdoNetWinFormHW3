using AdoNetWinFormHW3.Constans;
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
        public async Task<List<KeyValuePair<string, int>>> GetCountryPairs()
        {
            return await _context.Countries
                .Select(x => new KeyValuePair<string, int>(x.Name, x.Id))
                .ToListAsync();
        }
        public async Task AddCountry(string countryName, decimal area, PartOfWorld partOfWorld)
        {
            var country = new Country { Name = countryName, Area = area, PartOfWorld = partOfWorld  };
            await _context.Countries.AddAsync(country);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteCountry(int id)
        {
            var country = await _context.Countries.FindAsync(id);
            if (country != null)
            {
                
                _context.Countries.Remove(country);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Такой страны не существует");
            }
        }
        public async Task<Country?> GetCountryId(int id)
        {
            return await _context.Countries.FindAsync(id);
        }
    }
}
