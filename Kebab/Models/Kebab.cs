using Kebab.Enums;

namespace Kebab.Models;

// Verifier si il est végétarien et pescétarisme

public class Kebab {
    private List<Ingredient> Ingredients { get; }

    public void ShowRecipe()
    {
        Console.WriteLine("Votre kebab est composé de :");
        
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine(ingredient);
        }

		if (Ingredients.All(ingredient => !ingredient.IsMeat)) {
			Console.WriteLine("Ce kebab est végétarien");
		}
		else if (Ingredients.All(ingredient => !ingredient.IsFish)) {
			Console.WriteLine("Ce kebab est pescétarien");
		}
	}

    //Ici ca parle de Kebab
	public Kebab() {
		this.Ingredients = new();
	}
    
    //ici ça fait quelque chose
    public void AddIngredient(Ingredient ingredient)
    {
        this.Ingredients.Add(ingredient);
        Console.WriteLine($"Vous avez ajouté: {ingredient}");
	}
}
