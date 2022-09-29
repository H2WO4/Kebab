using Kebab.Models.Ingredients;
using Xunit;

namespace Kebab.Tests;

public class KebabTest {
	[Fact]
	public void TestCheese() {
		var kebab = new Models.Kebab();
		kebab.AddIngredient(new Cheese());
		kebab.AddIngredient(new Cheese());

		kebab.DoubleCheese();

		Assert.Equal(4, kebab.Ingredients.Count);
	}

	[Fact]
	public void TestOignons() {
		var kebab = new Models.Kebab();
		kebab.AddIngredient(new Oignon());

		kebab.RemoveOignons();

		Assert.Equal(0, kebab.Ingredients.Count);
	}
}
