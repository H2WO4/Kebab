using Kebab.Enums;

namespace Kebab.Models;

// Verifier si il est végétarien et pescétarisme

public class Kebab {
    private List<Viandes> viandes { get; set; }
    private List<Crudites> crudites { get; set; }

    public void ShowRecipe()
    {
        Console.WriteLine("Votre kebab est composé de :");
        
        foreach (var viande in viandes)
        {
            Console.WriteLine(viande);
        }
        
        foreach (var crudite in crudites)
        {
            Console.WriteLine(crudite);
        }
        
        if (viandes.Count == 0)
            Console.WriteLine("Le kebab est végétarien et pescétarien");//c'est pas bon
    }


    //Ici ca parle de Kebab
	public Kebab() {
		this.viandes = new();
		this.crudites = new();
	}

    //ici bah je sais plu tro
    public void AddViande(Viandes viande)
    {
        this.viandes.Add(viande);
        Console.WriteLine("Vous avez ajouté: " + viande.ToString());
    }
    
    //ici ça fait quelque chose
    public void AddCrudite(Crudites crudite)
    {
        this.crudites.Add(crudite);
        Console.WriteLine("Vous avez ajouté: " + crudite.ToString());
	}
}
