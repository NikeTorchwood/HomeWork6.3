internal class CatalogOfPlanets
{

    private int _errorCounter;
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
    public (int, int, string) GetPlanet(string name)
    {
        _errorCounter++;
        for (var i = 0; i < _planets.Count; i++)
        {
            if (_planets[i].Name == name)
            {
                if (_errorCounter % 3 == 0)
                {
                    return (_planets[i].IdFromSun, _planets[i].EquatorLength, "Вы спрашиваете слишком часто");
                }
                else
                {
                    return (_planets[i].IdFromSun, _planets[i].EquatorLength, "");
                }
            }
        }
        return (0, 0, "Не удалось найти планету");
    }
}
