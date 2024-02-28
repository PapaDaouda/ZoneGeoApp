using ZoneGeoApp.Data.Entities;
using ZoneGeoApp.Data.Entities.Abstraction;

namespace ZoneGeoApp.Data.FakeDb;

public static class FakeDatabase
{
    private static List<Pays> pays = new();
    private static List<Continent> continents = new()
    {

        new Continent("Afrique", 1300000000, 30370000, new Point(14.2350f, -51.9253f)),
        new Continent("Europe", 750000000, 10180000, new Point(54.5260f, 15.2551f)),
        new Continent("Asie", 4500000000, 44579000, new Point(34.0479f, 100.6197f)),
        new Continent("Amérique", 1000000000, 42330000, new Point(54.5260f, 105.2551f)),
        new Continent("Océanie", 42000000, 8564291, new Point(-25.2744f, 133.7751f))

    };

    public static List<Pays> GetAllPays()
    {
        return pays;
    }

    public static Pays? GetPays(string idPays)
    {
        var result = pays.FirstOrDefault(p => p.Id == idPays);

        return result;
    }

    public static void AddPays(Pays newPays)
    {
        pays.Add(newPays);
    }

    public static bool UpdatePays(Pays paysToUpdate)
    {
        // Recherche l'index du pays à travers son Id
        var index = pays.FindIndex(p => p.Id == paysToUpdate.Id);

        if (index == -1)
        {
            return false;
        }

        pays[index] = paysToUpdate;

        return true;
    }

    public static bool RemovePays(string idPays)
    {
        var result = pays.RemoveAll(p => p.Id == idPays);

        // Option 1
        // if(result > 0)
        // {
        //     return true;
        // } 
        // return false;

        // Option 2
        return result > 0 ? true : false;
    }

    public static List<Continent> GetAllContinents()
    {
        return continents;
    }

    public static Continent? GetContinent(string idContinent)
    {
        var result = continents.FirstOrDefault(p => p.Id == idContinent);

        return result;
    }

}
