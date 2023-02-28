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
        public async Task<List<KeyValuePair<string, int>>> GetCountryPairsAsync()
        {
            return await _context.Countries
                .Select(x => new KeyValuePair<string, int>(x.Name, x.Id))
                .ToListAsync();
        }
        public async Task<List<KeyValuePair<string, int>>> GetCityPairsAsync()
        {
            return await _context.Cities
                .Select(x => new KeyValuePair<string, int>(x.Name, x.Id))
                .ToListAsync();
        }

        public async Task AddCountry(string countryName, decimal area, PartOfWorld partOfWorld)
        {
            var country = new Country { Name = countryName, Area = area, PartOfWorld = partOfWorld  };
            await _context.Countries.AddAsync(country);
            await _context.SaveChangesAsync();
        }
        public async Task AddCity(string cityName, int population, int country)
        {
            var city = new City { Name = cityName, Population = population, CountryId = country };
            await _context.Cities.AddAsync(city);
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
        public async Task DeleteCity(int id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city != null)
            {
                _context.Cities.Remove(city);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Такого города не существует");
            }
        }
        public async Task<Country?> GetCountryId(int id)
        {
            return await _context.Countries.FindAsync(id);
        }
        public async Task<City?> GetCityId(int id)
        {
            return await _context.Cities.FindAsync(id);
        }
        public async Task EditCountry(Country country, string newName, decimal newArea, PartOfWorld newpartOfWorld, int newCapitalId)
        {
            country.Name = newName;
            country.Area = newArea;
            country.PartOfWorld = newpartOfWorld;
            country.CapitalId = newCapitalId;
            await _context.SaveChangesAsync();
        }
        public async Task EditCity(City city, string newName, int newPopulation, int newCountriId)
        {
            city.Name = newName;
            city.Population = newPopulation;
            city.CountryId = newCountriId;
            await _context.SaveChangesAsync();
        }
        public async Task<List<City>> GetCity(int countryId = 0)
        {
            if (countryId != 0)
            {
                return await _context.Cities
                .Where(x => x.CountryId == countryId)
                .ToListAsync();
            }

            return await _context.Cities.ToListAsync();
        }
        public void PopulateCombobox(ComboBox comboBox, List<KeyValuePair<string, int>> keyValuePairs, int id = 0)
        {
            var pairs = new List<KeyValuePair<string, int>>();
            pairs.Add(new("Не выбран", 0));
            pairs.AddRange(keyValuePairs);

            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
            comboBox.DataSource = pairs;
            comboBox.SelectedItem = pairs.First(x => x.Value == id);
        }
        public async Task<List<Country>> CapitalOver5K()
        {
            return await _context.Countries
                .Where(x => x.Capital.Population >= 5000000)
                .ToListAsync();
        }
        public async Task<List<string>> CountryName()
        {
            return await _context.Countries
                .Select(x => x.Name)
                .ToListAsync();
        }
       public async Task<List<string>> CapitalName()
        {
            return await _context.Countries
                .Select(x => x.Capital.Name)
                .ToListAsync();
        }
        public async Task<List<string>> GrandCity(int countryId)
        {
            if(countryId == 0)
            {
                return await _context.Cities
                .Where(x => x.Population > 1000000)
                .Select(x => x.Name)
                .ToListAsync();
            }
            return await _context.Cities
                .Where(x => x.CountryId == countryId && x.Population > 1000000)
                .Select(x => x.Name)
                .ToListAsync();
        }
    }
}
