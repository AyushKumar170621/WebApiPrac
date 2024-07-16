using WebApiPractice.Modals;

namespace WebApiPractice.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwners(int ownerId);

        ICollection<Owner> GetOwnersFromCountry(int  countryId);
        bool CountryExists(int id);

    }
}
