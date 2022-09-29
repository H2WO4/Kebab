using Kebab.Enums;

namespace Kebab;

public class Program
{
	static int Main()
	{
		var kebab = new Models.Kebab();

		kebab.AddIngredient(new Beef());
		kebab.AddIngredient(new Salad());
		kebab.AddIngredient(new Tomato());

		kebab.ShowRecipe();

		Console.WriteLine("Merci d'être passé au Kebab de 'chez les chefs'");
		return 0;
	}

	static Models.Kebab NewKebab()
	{
		Console.WriteLine("Que voulez vous dans le kebab ?");

        var kebab = new Models.Kebab();
        int choixIngre = -1;

		while (true)
		{
			Console.WriteLine("1 : Viande, 2 : Crudité\n0 : Finir creation du kebab");
			var choix = Console.ReadLine();

			if (int.TryParse(choix, out choixIngre))
			{
				if (choixIngre == 0)
					break;
				if (choixIngre == 1)
				{
					var viande = AskViandes();
					if (viande != null)
						kebab.AddViande(viande.Value);
					else
						Console.WriteLine("Mauvais choix");

				}
				else if (choixIngre == 2)
				{
					var crudite = AskCrudites();
					if (crudite != null)
						kebab.AddCrudite(crudite.Value);
					else
						Console.WriteLine("Mauvais choix");
				}
				else
				{
					Console.WriteLine("Mauvais choix");
				}
			}
		}

		return kebab;

    }

	static Crudites? AskCrudites()
    {
        foreach (Crudites crudite in Enum.GetValues(typeof(Crudites)))
        {
            Console.WriteLine($"{(int)crudite} : {crudite}");
        }

		var choix = Console.ReadLine();

		if (int.TryParse(choix, out var crud))
			return (Crudites)crud;
		else
			return null;
    }

    static Viandes? AskViandes()
    {
        foreach (Viandes viande in Enum.GetValues(typeof(Viandes)))
        {
            Console.WriteLine($"{(int)viande} : {viande}");
        }

        var choix = Console.ReadLine();

        if (int.TryParse(choix, out var crud))
            return (Viandes)crud;
        else
            return null;
    }
}
