using ZoneGeoApp.Data.Entities.Abstraction;

namespace ZoneGeoApp.Data.Entities;

public class Pays : ZoneGeo
{
    public Pays(string nom, long population, 
        float superficie, Point localisation) 
        : base(nom, population, superficie, localisation)
    {
    }

    public string IdContinent {get; set;}
    public DateOnly DateIndependance {get; set;}
    public string DirigeantActuel { get; set; }
    public string Capital { get; set; }
    public List<string> PaysLimitrophe { get; set;} = new();

    public override string Description()
    {
        string listeDesPays = string.Empty;
        foreach (var pays in PaysLimitrophe)
        {
            listeDesPays += $"{pays} - ";
        }
        
        return $"Type: Pays\n"+
            base.Description()+
            $"Capital: {Capital}\n"+
            $"Dirigeant Actuel: {DirigeantActuel}\n"+
            $"Pays Limitrophes: {listeDesPays}";
    }
    
}
