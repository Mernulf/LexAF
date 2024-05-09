using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class FizzBuzzConsole
{
    public static void Main()
    {
        //Initialisera variabler
        int X = 0; int Y = 0; int N = 0; int S = 0;

        //Titel
        Console.WriteLine("FizzBuzz\r");
        // Nämnare 1
        Console.WriteLine("X?");
        X = Convert.ToInt32(Console.ReadLine()); // Heltal

        // Nämnare 2
        Console.WriteLine("Y?");
        Y = Convert.ToInt32(Console.ReadLine()); // Heltal

        //Antal
        Console.WriteLine("Längd > 0 ?");
        N = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Heltal > 0
        Console.WriteLine(" Linq or If Else 1/2 ?");
        S = Convert.ToInt32(Console.ReadLine());

        //Linq version
        switch (S)
        {
            case 1:
                Console.WriteLine("LINQ variant______________________");
                Enumerable.Range(1, N).Select(x =>
                (x % (X * Y) == 0) ? "FizzBuzz" :            
                (x % X == 0) ? "Fizz" :
                (x % Y == 0) ? "Buzz" :
                x.ToString()).ToList().ForEach(Console.WriteLine);
                break;

            case 2:
                Console.WriteLine("If Variant________________________");
                for (int i = 1; i <= N; i++)
                {
                    if (i % (X * Y) == 0)
                    //if (i % X == 0 && i % Y == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % X == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % Y == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                break;
        }
    }
}
//EOF