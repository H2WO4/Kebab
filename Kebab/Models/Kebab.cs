using Kebab.Enums;

namespace Kebab.Models;

public class Kebab {
    private Ingredient[] Ingredients { get; set; }

    public void ShowRecipe()
    {
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine(ingredient);
        }
    }
}
