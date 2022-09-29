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

	static void AskRecipe()
	{
		Console.WriteLine("Que voulez vous dans le kebab ?");

		int choixIngre = -1;

		Console.WriteLine("1 : Viande, 2 : Crudité");
		var choix = Console.ReadLine();
		if (int.TryParse(choix, out choixIngre))
		{

			// TO REDO
		}
	}
}
