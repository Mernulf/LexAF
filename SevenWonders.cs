using System;

public class SevenWonders
{
    public static void Main(string[] args)
    {
        //Initialize
        int T = 0;
        int C = 0;
        int G = 0;
        int min = 0;
        string cards = Console.ReadLine();
        
        //Loop through numbers and count cards
        for (int x = 0; x < cards.Length; x++)
        {
            if (cards[x] == 'T')
                T++;
            else if (cards[x] == 'C')
                C++;
            else
               G++;
        }

        //check # Unique sets     
        if ((T <= C) && (T <= G))
           min = T;
        else if((C <= G) && (C<=T))
            min = C;
        else
            min = G;
        Console.WriteLine((int)(Math.Pow(T, 2) + Math.Pow(C, 2) + Math.Pow(G, 2) + min * 7));
    }
}