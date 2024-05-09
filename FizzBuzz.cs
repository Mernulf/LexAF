#define DEBUG
#undef  DEBUG

/*______________________________________________________/
/   Takes StringArray [X Y N] as input                  /
/   If X or Z is even divisible with Number[1:N]        /
/   outputs Fizz, Buzz or FizzBuzz, otherwise i         /
/   Mernulf   240506                                    /
/______________________________________________________*/

public class Program
{
    public static void Main()
    {
        //Initialisera variabler
        int X = 0; int Y = 0; int N = 0;
        string[] Inp = Console.ReadLine().Split(' ');

        X = Convert.ToInt32(Inp[0]);

        // Nämnare 2
        Y = Convert.ToInt32(Inp[1]);
        // Antal
        N = Convert.ToInt32(Inp[2]);
#if DEBUG
        Console.WriteLine(X);
        Console.WriteLine(Y);
        Console.WriteLine(N);
#endif
        for (int i = 1; i <= N; i++)
        {
            //if (i % (X * Y) == 0)
            if (i % X == 0 && i % Y == 0)
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

    }
}