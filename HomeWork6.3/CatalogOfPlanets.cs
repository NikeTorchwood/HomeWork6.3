delegate string? PlanetValidator(string planetName);

internal class CatalogOfPlanets
{
    public int ErrorCounter;
    private readonly List<Planet> _planets = new();
    public CatalogOfPlanets()
    {
        var venus = new Planet("Венера", 2, 38025, null);
        var earth = new Planet("Земля", 3, 47075, venus);
        var mars = new Planet("Марс", 4, 21344, earth);
        _planets.Add(venus);
        _planets.Add(earth);
        _planets.Add(mars);
    }
    public (int, int, string?) GetPlanet(string name, PlanetValidator validator)
    {
        var error = validator(name);
        foreach (var planet in _planets)
        {
            if (error != null)
            {
                return (0, 0, error);
            }
            else
            {
                if (planet.Name == name)
                {
                    {
                        return (planet.IdFromSun, planet.EquatorLength, error);
                    }
                }
            }
        }
            return (0, 0, "Не удалось найти планету");
        }
    }
