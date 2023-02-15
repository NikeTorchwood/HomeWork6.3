internal class Program
{

    public static string s = new string('-', 50);
    private static void Main()
    {
        var catalog = new CatalogOfPlanets();
        var res1 = catalog.GetPlanet("Земля");
        var res2 = catalog.GetPlanet("Лимония");
        var res3 = catalog.GetPlanet("Марс");
        PrintRes(res1);
        PrintRes(res2);
        PrintRes(res3);
    }

    private static void PrintRes((int, int, string) res)
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