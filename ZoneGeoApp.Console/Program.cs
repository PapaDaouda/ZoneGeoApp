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
    } else if(choixMenuInt == 2)
    {
        var pays = paysService.GetAllPays();
        Console.WriteLine("###############");          

        foreach (var p in pays)
        {
            Console.WriteLine(p);          
            Console.WriteLine("###############");          
        }
    } else if(choixMenuInt == 3)
    {
        Console.WriteLine("####### Ajout de pays ########");   
        Console.WriteLine("Donnez le nom du pays: ");
        string nom = Console.ReadLine();

        Console.Write("Donnez la superficie du pays: ");
        float superficie = float.Parse(Console.ReadLine());

        // Saisie de la localisation
        Console.WriteLine("Veuillez donner les coordonnées géographique du pays");
        Console.Write("longitude: ");
        float longitude = float.Parse(Console.ReadLine());
        Console.Write("latitude: ");
        float latitude = float.Parse(Console.ReadLine());

        Console.Write("Donnez la population du pays: ");
        long population = long.Parse(Console.ReadLine());

        // Affiche la liste des continents
        Console.Write("Veuiller choisir le continent du pays: ");
        var continents = continentService.GetAllContinents();

        for (int i = 0; i < continents.Count(); i++)
        {
            Console.WriteLine($"{i+1} - {continents[i].Nom}");          
        }

        Console.Write("Votre choix: ");
        int choixContinent = int.Parse(Console.ReadLine());

        int indexContinent = choixContinent -1 ;
        string idContinent = continents[indexContinent].Id;

        CreatePaysDto paysDto = new CreatePaysDto(nom, superficie,
                                    latitude, longitude,population);

        paysService.AddPays(paysDto, idContinent);
        
    }

} else {
    Console.WriteLine("Erreur: Veuiller faire un bon choix");
}


