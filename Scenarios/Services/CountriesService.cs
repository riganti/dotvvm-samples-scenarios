using System.Collections.Generic;
using System.Linq;
using Scenarios.Data;
using Scenarios.Model;

namespace Scenarios.Services;

public class CountriesService
{
    private readonly AppDbContext appDbContext;

    public CountriesService(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public List<ContinentModel> GetContinents()
    {
        return appDbContext.Continents
            .Select(c => new ContinentModel()
            {
                Id = c.Id,
                Name = c.Name
            })
            .ToList();
    }

    public List<CountryModel> GetCountries(int continentId)
    {
        return appDbContext.Countries
            .Where(c => c.ContinentId == continentId)
            .Select(c => new CountryModel()
            {
                Id = c.Id,
                Name = c.Name
            })
            .ToList();
    }

    public IQueryable<CountryListModel> GetCountriesQueryable()
    {
        return appDbContext.Countries
            .Select(c => new CountryListModel()
            {
                Id = c.Id,
                Name = c.Name,
                ContinentName = c.Continent.Name,
                ContinentId = c.ContinentId
            });
    }

    public void SaveCountry(CountryListModel country)
    {
        var item = appDbContext.Countries.Find(country.Id);
        item.Name = country.Name;
        item.ContinentId = country.ContinentId;
        appDbContext.SaveChanges();
    }

    public void DeleteCountry(CountryListModel country)
    {
        var item = appDbContext.Countries.Find(country.Id);
        appDbContext.Countries.Remove(item);
        appDbContext.SaveChanges();
    }
}