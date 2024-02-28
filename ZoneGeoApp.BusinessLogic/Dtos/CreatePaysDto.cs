namespace ZoneGeoApp.BusinessLogic;

public record class CreatePaysDto(
    string Nom,
    float Superficie,
    float Latitude,
    float Longitude,
    long Population
);
