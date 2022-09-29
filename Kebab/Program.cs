using Kebab.Enums;
using Kebab.Models;

namespace Kebab;

public class Program
{
	static int Main()
	{
		var ingredients = new[] { Viandes.Boeuf };
		var kebab = new Models.Kebab();

		kebab.AddViande(Viandes.Agneau);
		kebab.AddCrudite(Crudites.Salade);
		kebab.AddCrudite(Crudites.Tomate);
		kebab.AddCrudite(Crudites.Oignon);

		kebab.ShowRecipe();

		Console.WriteLine("Merci d'être passé au Kebab de 'chez les chefs'");
		return 0;
	}

	static void AskRecipe()
	{
		Console.WriteLine("Que voulez vous dans le kebab ?");

		int choixIngre = -1;

		Console.WriteLine("1 : Viande, 2 : Crudité");
		var choix = Console.ReadLine();
		if (int.TryParse(choix, out choixIngre))
		{

			if (choixIngre == 1)
			{
				foreach (Viandes Viande in Enum.GetValues(typeof(Viandes)))
				{
					Console.WriteLine($"{(int)Viande} : {Viande.ToString()}");
				}
			}
			else if (choixIngre == 2) {
				foreach (Crudites Crudite in Enum.GetValues(typeof(Crudites)))
				{
					Console.WriteLine($"{(int)Crudite} : {Crudite.ToString()}");
				}
			}
			else
			{
				Console.WriteLine("Mauvais choix");
			}
		}
	}
}
