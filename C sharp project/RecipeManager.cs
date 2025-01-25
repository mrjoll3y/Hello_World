using system;
class RecipeManager
{
    private List<Recipe> recipes = new List<Recipe>();

    public void AddRecipe()
    {
        Console.Write("Enter recipe name: ");
        string name = Console.ReadLine();
        Console.Write("Enter ingredients (comma-separated): ");
        string ingredients = Console.ReadLine();
        Console.Write("Enter instructions: ");
        string instructions = Console.ReadLine();

        recipes.Add(new Recipe(name, ingredients, instructions));
        Console.WriteLine("Recipe added successfully!");
    }

    public void SearchRecipeByName()
    {
        Console.Write("Enter recipe name to search: ");
        string name = Console.ReadLine();

        var results = recipes.FindAll(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (results.Count > 0)
        {
            Console.WriteLine("\nRecipes found:");
            results.ForEach(r => Console.WriteLine(r));
        }
        else
        {
            Console.WriteLine("No recipes found with that name.");
        }
    }

    public void SearchRecipeByIngredient()
    {
        Console.Write("Enter an ingredient to search: ");
        string ingredient = Console.ReadLine();

        var results = recipes.FindAll(r => r.Ingredients.Contains(ingredient, StringComparison.OrdinalIgnoreCase));

        if (results.Count > 0)
        {
            Console.WriteLine("\nRecipes found:");
            results.ForEach(r => Console.WriteLine(r));
        }
        else
        {
            Console.WriteLine("No recipes found with that ingredient.");
        }
    }

    public void ListAllRecipes()
    {
        if (recipes.Count > 0)
        {
            Console.WriteLine("\nAll Recipes:");
            recipes.ForEach(r => Console.WriteLine(r));
        }
        else
        {
            Console.WriteLine("No recipes available.");
        }
    }
}