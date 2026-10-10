using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите профессию: ");
        string input = Console.ReadLine();

        string drink;

        switch (input.Trim().ToLower())
        {
            case "jabroni":
                drink = "Patron Tequila";
                break;
            case "school counselor":
                drink = "Anything with Alcohol";
                break;
            case "programmer":
                drink = "Hipster Craft Beer";
                break;
            case "bike gang member":
                drink = "Moonshine";
                break;
            case "politician":
                drink = "Your tax dollars";
                break;
            case "rapper":
                drink = "Cristal";
                break;
            default:
                drink = "Beer";
                break;
        }

        Console.WriteLine(drink);
    }
}