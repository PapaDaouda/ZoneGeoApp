using ZoneGeoApp.Data.Entities;
using ZoneGeoApp.Data.FakeDb;

namespace ZoneGeoApp.BusinessLogic.Services;

public class PaysService
{
    public List<Pays> GetAllPays()
    {
        return FakeDatabase.GetAllPays();
    }

    public Pays? GetPays(string id)
    {
        bool isValidId = Guid.TryParse(id, out Guid idInGuid);

        if (!isValidId)
        {
            throw new Exception("Id invalid");
        }
        return FakeDatabase.GetPays(id);
    }

    public void AddPays(Pays pays, string idContinent)
    {
        if (pays is null)
        {
            throw new Exception("Le pays ne peut pas etre null");
        }

        var continent = FakeDatabase.GetContinent(idContinent);

        if (continent is null)
        {
            throw new Exception("Continent inexistant");
        }

        pays.IdContinent = idContinent;

        FakeDatabase.AddPays(pays);

    }
}
