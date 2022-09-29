namespace Kebab.Enums;

public abstract class Ingredient
{
    public string Name = "";
    
    public bool IsMeat;
    public bool IsFish;

	protected Ingredient(string name, bool isMeat, bool isFish)
	{
		Name = name;
		IsMeat = isMeat;
		IsFish = isFish;
	}
	public override string? ToString()
	{
		return Name;
	}
}
