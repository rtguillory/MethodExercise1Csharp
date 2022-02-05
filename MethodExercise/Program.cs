// See https://aka.ms/new-console-template for more information
//


Story();
var sum = Add(2, 3, 4);
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {Subtract(1, 2)}");
Console.WriteLine($"Difference: {Subtract(5, 2)}");
Console.WriteLine($"Product: {Multiply(1, 2, 3)}");
Console.WriteLine($"Quotient: {Divide(17, 2)}");
Console.WriteLine($"Modulus: {Modulus(12,5)}");

static string Color()
{
    Console.WriteLine("What is your favorite color?");
    var favoriteColor = Console.ReadLine();
    if(favoriteColor != null)
        return favoriteColor;
    return "";
}

static string Name()
{
    Console.WriteLine("What is your name?");
    var name = Console.ReadLine();
    if (name == null)
        return "";
    return name;
}

static string Band()
{
    Console.WriteLine("What is your favorite band?");
    string favoriteBand = Console.ReadLine();
    if (favoriteBand == null)
        return "";
    return favoriteBand;
}

static string Animal()
{
    Console.WriteLine("What is your favorite animal?");
    string favoriteAnimal = Console.ReadLine();
    if (favoriteAnimal == null)
        return "";
    return favoriteAnimal;
}

static void Story()
{
    var favoriteColor = Color();
    var favoriteAnimal = Animal();
    var name = Name();
    var band = Band();
    Console.WriteLine($"Did you know that {name} wants to form a band to cover {band} songs?");
    Console.WriteLine($"{name} wants to call it the {char.ToUpper(favoriteColor[0])}{favoriteColor.Substring(1)} {char.ToUpper(favoriteAnimal[0])}{favoriteAnimal.Substring(1)}!");
}



static int Add(params int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
    }
    return sum;
}

static int Subtract(int a, int b)
{
    return a-b;
}

static int Multiply(params int[] nums)
{
    int product = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        product += nums[i];
    }
    return product;
}

static double Divide(double a, double b)
{
    return a/b;
}


static int Modulus(int a, int b)
{
    return a % b;
}

