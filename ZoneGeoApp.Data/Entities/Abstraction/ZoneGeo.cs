namespace ZoneGeoApp.Data.Entities.Abstraction;

public abstract class ZoneGeo
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    private string _nom;
    public ZoneGeo(string nom, long population,
        float superficie, Point localisation)
    {
        Nom = nom;
        Population = population;
        Superficie = superficie;
        Localisation = localisation;

    }
    public string Nom
    {
        get { return _nom; }
        set
        {
            if (value.Length < 2)
            {
                throw new Exception("Un nom doit avoir plus de 2 lettres");
            }
            else
            {
                _nom = value;
            }
        }
    }
    public float Superficie { get; set; }
    public Point Localisation { get; set; }
    public long Population { get; set; }
    public float Densite()
    {
        return Population / Superficie;
    }


    public virtual string Description()
    {
        return $"Id: {Id} \n" +
                $"Nom: {Nom} \n" +
                $"Superficie: {Superficie}\n" +
                $"Localisation: {Localisation}\n" +
                $"Population: {Population}\n" +
                $"Densité: {Densite()}\n";
    }

}
