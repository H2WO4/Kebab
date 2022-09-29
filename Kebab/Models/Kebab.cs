using Kebab.Models.Ingredients;

namespace Kebab.Models;

// Verifier si il est végétarien et pescétarisme

public class Kebab
{
	public List<Ingredient> Ingredients { get; set; }

	public void ShowRecipe()
	{
		Console.WriteLine("Votre kebab est composé de :");

		Console.WriteLine(string.Join(", ", Ingredients));

		if (Ingredients.All(ingredient => !ingredient.IsMeat))
		{
			Console.WriteLine("Ce kebab est végétarien");
		}
		else if (Ingredients.All(ingredient => !ingredient.IsFish))
		{
			Console.WriteLine("Ce kebab est pescétarien");
		}
	}

	//Ici ca parle de Kebab
	public Kebab()
	{
		this.Ingredients = new();
	}

	//ici ça fait quelque chose
	public void AddIngredient(Ingredient ingredient)
	{
		this.Ingredients.Add(ingredient);
		Console.WriteLine($"Vous avez ajouté: {ingredient}");
	}

	public void DoubleCheese()
	{
		Ingredients = Ingredients.SelectMany(ingredient => ingredient.IsCheese ? new[] { ingredient, ingredient } : new[] { ingredient }).ToList();
	}

	public void RemoveOignons()
	{
		Ingredients.RemoveAll(ingredient => ingredient.Name == "Oignons");
	}
}
