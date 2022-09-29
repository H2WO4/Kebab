using Kebab.Models.Ingredients;

namespace Kebab;

public class Program
{
	static int Main()
	{
		var kebab = NewKebab();

		Console.WriteLine("Voulez-vous doubler le fromage ? (O/N)");
		var doubleCheese = Console.ReadLine() ?? "";
		if (doubleCheese.ToLower() == "o")
		{
			kebab.DoubleCheese();
		}

		Console.WriteLine("Voulez-vous retirer les oignons ? (O/N)");
		var removeOignons = Console.ReadLine() ?? "";
		if (removeOignons.ToLower() == "o")
		{
			kebab.RemoveOignons();
		}

		kebab.ShowRecipe();

		Console.WriteLine("Merci d'être passé au Kebab de 'chez les chefs'");
		return 0;
	}

	static Models.Kebab NewKebab()
	{
		Console.WriteLine("Que voulez vous dans le kebab ?");

		var kebab = new Models.Kebab();

		Ingredient[] possibleIngredients = AppDomain.CurrentDomain.GetAssemblies()
				.SelectMany(domainAssembly => domainAssembly.GetTypes())
				.Where(type => type.IsSubclassOf(typeof(Ingredient)))
				.Select(type => Activator.CreateInstance(type) as Ingredient ?? throw new Exception() ?? throw new Exception()).ToArray() ?? throw new Exception();

		foreach (var ingredient_ in possibleIngredients)
		{
			Console.WriteLine($"{Array.IndexOf(possibleIngredients, ingredient_)} - {ingredient_}");
		}

		Console.WriteLine();
		Console.WriteLine("Dite \"Fini\" pour terminer la creation de votre kebab");

		while (true)
		{
			var choix = Console.ReadLine() ?? "";

			var ingredient = possibleIngredients.SingleOrDefault(ingredient => ingredient?.Name.ToLower() == choix.ToLower(), null);

			if (ingredient != null)
			{
				Console.WriteLine("Combien ?");
				var quantite = Console.ReadLine();

				while (true)
				{
					if (int.TryParse(quantite, out var quantiteInt))
					{
						for (int i = 0; i < quantiteInt; i++)
							kebab.AddIngredient(ingredient);

						break;
					}
					else
						Console.WriteLine("Entré un chiffre");
				}
			}
			else if (choix.ToLower() == "fini")
				break;
			else
				Console.WriteLine("Mauvais choix");
		}

		return kebab;
	}
}
