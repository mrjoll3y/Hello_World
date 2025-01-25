using system;
class Program
{
    static void Main()
    {
        RecipeManager manager = new RecipeManager();

        while (true)
        {
            Console.WriteLine("\nRecipe Management System");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. Search Recipe by Name");
            Console.WriteLine("3. Search Recipe by Ingredient");
            Console.WriteLine("4. List All Recipes");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.AddRecipe();
                    break;
                case "2":
                    manager.SearchRecipeByName();
                    break;
                case "3":
                    manager.SearchRecipeByIngredient();
                    break;
                case "4":
                    manager.ListAllRecipes();
                    break;
                case "5":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}