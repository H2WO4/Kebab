using Kebab.Models;

namespace Kebab;

public class Program {
    static int Main()
    {
        var kebab = new Models.Kebab();

        kebab.ShowRecipe();

        Console.WriteLine("Merci d'être passé au Kebab de chez les chefs");
        return 0;
    }
}
