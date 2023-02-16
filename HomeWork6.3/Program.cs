internal class Program
{
    public static string s = new('-', 50);
    private static void Main()
    {
        var catalog = new CatalogOfPlanets();
        PlanetValidator validator = (string name) =>
        {
                catalog.ErrorCounter++;
                if (catalog.ErrorCounter % 3 == 0)
                {
                    return "Вы спрашиваете слишком часто";
                }
                return null;
            
        };
        PlanetValidator lemon = (string name) =>
        {
            if (name == "Лимония")
            {
                return "Это запретная планета";
            }
            return null;
        };
        var res1 = catalog.GetPlanet("Земля", validator);
        var res2 = catalog.GetPlanet("Лимония", validator);
        var res3 = catalog.GetPlanet("Марс", validator);
        PrintRes(res1);
        PrintRes(res2);
        PrintRes(res3);
        var res4 = catalog.GetPlanet("Земля", lemon);
        var res5 = catalog.GetPlanet("Лимония", lemon);
        var res6 = catalog.GetPlanet("Марс", lemon);
        PrintRes(res4);
        PrintRes(res5);
        PrintRes(res6);
    }

    private static void PrintRes((int, int, string?) res)
    {
        if (res.Item1 != 0)
        {
            Console.WriteLine($"Порядковый номер от солнца: {res.Item1}");
            Console.WriteLine($"Длина экватора в км: {res.Item2}");
        }
        Console.WriteLine(res.Item3);
        Console.WriteLine(s);

    }

}