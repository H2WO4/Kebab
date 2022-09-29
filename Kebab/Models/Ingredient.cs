namespace Kebab.Models.Ingredients;

public abstract class Ingredient
{
    public string Name = "";
    
    public bool IsMeat;
    public bool IsFish;
    public bool IsCheese;

	protected Ingredient(string name, bool isMeat, bool isFish, bool isCheese = false)
	{
		Name = name;
		IsMeat = isMeat;
		IsFish = isFish;
		IsCheese = isCheese;
	}

	public override string? ToString()
	{
		return Name;
	}
}
