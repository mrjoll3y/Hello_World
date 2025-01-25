using system;
class Recipe
{
    public string Name { get; set; }
    public string Ingredients { get; set; }
    public string Instructions { get; set; }

    public Recipe(string name, string ingredients, string instructions)
    {
        Name = name;
        Ingredients = ingredients;
        Instructions = instructions;
    }

    public override string ToString()
    {
        return $"\nName: {Name}\nIngredients: {Ingredients}\nInstructions: {Instructions}";
    }
}