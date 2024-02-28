using ZoneGeoApp.BusinessLogic;
using ZoneGeoApp.BusinessLogic.Services;

PaysService paysService = new PaysService();
ContinentService continentService = new();

Console.WriteLine("Binevenue dans notre application de gestion de Zone Geo.\n");
Console.WriteLine("Veuillez faire un choix\n");
Console.WriteLine("1 - Voir la liste des continents\n");
Console.WriteLine("2 - Voir la liste des pays\n");
Console.WriteLine("3 - Ajouter un pays\n");
Console.Write("Votre choix: ");
string choixMenu = Console.ReadLine();


if(int.TryParse(choixMenu, out int choixMenuInt)){
    if(choixMenuInt == 1)
    {
        var continents = continentService.GetAllContinents();
        Console.WriteLine("###############");          

        foreach (var continent in continents)
        {
            Console.WriteLine(continent);          
            Console.WriteLine("###############");          
        }
    }

} else {
    Console.WriteLine("Erreur: Veuiller faire un bon choix");
}


