using ZoneGeoApp.Data.Entities;
using ZoneGeoApp.Data.FakeDb;

namespace ZoneGeoApp.BusinessLogic;

public class ContinentService
{
    public List<Continent> GetAllContinents()
    {
        return FakeDatabase.GetAllContinents();
    }
}
