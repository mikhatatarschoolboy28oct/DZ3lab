using System;


class Program
{
    static void Main()
    {
        string[] toys={"Hello Kitty","Barbie doll","Spider-Man","Lego","Ball"};
        int n=0;
        foreach(string toy in toys)
        {
            if(toy=="Hello Kitty"||toy=="Barbie doll")
            {
                n++;
                
            }
            
            
        }
        Console.WriteLine($"Количество кукол в сумке:{n}");

    }
}