using ZoneGeoApp.Data.Entities.Abstraction;

namespace ZoneGeoApp.Data.Entities;

public class Continent : ZoneGeo
{
    public Continent(string nom, long population, 
        float superficie, Point localisation) 
        : base(nom, population, superficie, localisation)
    {
    }

    public override string Description()
    {
        
        return $"Type: Continent\n"+
            base.Description();
    }

    public override string ToString()
    {
        
        return $"Type: Continent\n"+
            base.Description();
    }

}
