using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите профессию: ");
        string input = Console.ReadLine();

        Console.WriteLine(GetDrink(input));
    }

    static string GetDrink(string input)
    {
        switch (input.Trim().ToLower())
        {
            case "jabroni":
                return "Patron Tequila";
            case "school counselor":
                return "Anything with Alcohol";
            case "programmer":
                return "Hipster Craft Beer";
            case "bike gang member":
                return "Moonshine";
            case "politician":
                return "Your tax dollars";
            case "rapper":
                return "Cristal";
            default:
                return "Beer";
        }
    }
}