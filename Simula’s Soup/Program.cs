// See https://aka.ms/new-console-template for more information

Console.Title = "Simula’s Soup";

(Foodtype type, Ingredient ingredient, Seasoning seasoning) soup = GetSoup();
Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.type}");

(Foodtype, Ingredient, Seasoning) GetSoup()
{
    Foodtype type = GetFoodtype();
    Ingredient ingredient = GetIngredient();
    Seasoning seasoning = GetSeasoning();
    return (type, ingredient, seasoning);
}

Foodtype GetFoodtype()
{
    Console.Write("Soup type (soup, stew, gumbo): ");
    string answer = Console.ReadLine();
    return answer switch
    {
        "soup" => Foodtype.soup,
        "stew" => Foodtype.stew,
        "gumbo" => Foodtype.gumbo
    };
}

Ingredient GetIngredient()
{
    Console.Write("Main ingredient (mushroom, chicken, carrot, potato): ");
    string answer = Console.ReadLine();
    return answer switch
    {
        "mushroom" => Ingredient.mushrooms,
        "chicken" => Ingredient.chicken,
        "carrot" => Ingredient.carrots,
        "potato" => Ingredient.potatoes
    };
}

Seasoning GetSeasoning()
{
    Console.Write("Seasoning (spicy, salty, sweet): ");
    string answer = Console.ReadLine();
    return answer switch
    {
        "spicy" => Seasoning.spicy,
        "salty" => Seasoning.salty,
        "sweet" => Seasoning.sweet,
    };
}


enum Foodtype
{
    soup,
    stew,
    gumbo
}

enum Ingredient
{
    mushrooms, 
    chicken, 
    carrots, 
    potatoes
}

enum Seasoning
{
    spicy, 
    salty, 
    sweet
}