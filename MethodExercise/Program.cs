// See https://aka.ms/new-console-template for more information
//

//Exercise 1
//Abstracted into methods
Story();

//Exercise 2 -- call each method and print results
var sum = Add(2, 3, 4);
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {Subtract(1, 2)}");
Console.WriteLine($"Difference: {Subtract(5, 2)}");
Console.WriteLine($"Product: {Multiply(1, 2, 3)}");
Console.WriteLine($"Quotient: {Divide(17, 2)}");
Console.WriteLine($"Modulus: {Modulus(12,5)}");

//Ex 1 -- //Ex 1 -- method to get user's favorite color
static string Color()
{
    Console.WriteLine("What is your favorite color?");
    var favoriteColor = Console.ReadLine();
    if(favoriteColor != null)
        return favoriteColor;
    return "";
}
//Ex 1 -- method to get  user name
static string Name()
{
    Console.WriteLine("What is your name?");
    var name = Console.ReadLine();
    if (name == null)
        return "";
    return name;
}
//Ex 1 -- method to get user's favorite band
static string Band()
{
    Console.WriteLine("What is your favorite band?");
    string favoriteBand = Console.ReadLine();
    if (favoriteBand == null)
        return "";
    return favoriteBand;
}
//Ex 1 -- method to get user's favorite animal
static string Animal()
{
    Console.WriteLine("What is your favorite animal?");
    string favoriteAnimal = Console.ReadLine();
    if (favoriteAnimal == null)
        return "";
    return favoriteAnimal;
}
//Ex 1 -- call methods for name and favorite things and create story
static void Story()
{
    var favoriteColor = Color();
    var favoriteAnimal = Animal();
    var name = Name();
    var band = Band();
    Console.WriteLine($"Did you know that {name} wants to form a band to cover {band} songs?");
    Console.WriteLine($"{name} wants to call it the {char.ToUpper(favoriteColor[0])}{favoriteColor.Substring(1)} {char.ToUpper(favoriteAnimal[0])}{favoriteAnimal.Substring(1)}!");
}


//Ex 2 -- method to find sum using params key word
static int Add(params int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
    }
    return sum;
}

//Ex 2 -- method to find difference of 2 numbers
static int Subtract(int a, int b)
{
    return a-b;
}

//Ex 2 -- method to find product using params key word
static int Multiply(params int[] nums)
{
    int product = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        product += nums[i];
    }
    return product;
}

//Ex 2 -- method to find quotient of 2 doubles.
static double Divide(double a, double b)
{
    return a/b;
}

//Ex 2 -- method to find modulus for 2 ints
static int Modulus(int a, int b)
{
    return a % b;
}

