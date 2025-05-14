using Pokemon_reviewApp.Models;

namespace Pokemon_reviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection <Country> GetCountries ();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExists(int Id);
        bool CreateCountry(Country country);
        bool Save();
    }
}
