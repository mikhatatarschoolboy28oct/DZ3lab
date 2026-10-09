using System;


    enum Day
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
class Program
{
    static void Main()
    {
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 1 && n <= 7)
        {
            Day day = (Day)n;

            switch (day)
            {
                case Day.Monday:    Console.WriteLine("понедельник"); break;
                case Day.Tuesday:   Console.WriteLine("вторник"); break;
                case Day.Wednesday: Console.WriteLine("среда"); break;
                case Day.Thursday:  Console.WriteLine("четверг"); break;
                case Day.Friday:    Console.WriteLine("пятница"); break;
                case Day.Saturday:  Console.WriteLine("суббота"); break;
                case Day.Sunday:    Console.WriteLine("воскресенье"); break;
            }
        }
        else
        {
            Console.WriteLine("Ошибка: нужно ввести число от 1 до 7");
        }
    }

    
}