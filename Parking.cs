#define DEBUG
#undef  DEBUG

/*______________________________________________________/
/   Kattis Parking                                      /
/   Three trucks A B C, Three costs depending on number /
/   of Trucks parked.                                   /
/   ME 240509                                           /
/______________________________________________________*/

using System;

public class Program
{
    public static void Main()
    {
        //Initialisera variabler
        int A = 0; int B = 0; int C = 0;
        int ar1 = 0; int de1 = 0;           // Arrival and Dep. Truck A
        int ar2 = 0; int de2 = 0;           // Arrival and Dep. Truck B
        int ar3 = 0; int de3 = 0;           // Arrival and Dep. Truck C
       
        //Some splitting can be done nicer
        
        string[] L1 = Console.ReadLine().Split(' ');
        A = Convert.ToInt32(L1[0]);
        B = Convert.ToInt32(L1[1]);
        C = Convert.ToInt32(L1[2]);
        string[] L2 = Console.ReadLine().Split(' ');
        ar1 = Convert.ToInt32(L2[0]);
        de1 = Convert.ToInt32(L2[1]);
        string[] L3 = Console.ReadLine().Split(' ');
        ar2 = Convert.ToInt32(L3[0]);
        de2 = Convert.ToInt32(L3[1]);
        string[] L4 = Console.ReadLine().Split(' ');
        ar3 = Convert.ToInt32(L4[0]);
        de3 = Convert.ToInt32(L4[1]);
#if DEBUG
        Console.WriteLine("{0} {1} {2}", A, B, C);
        Console.WriteLine("{0} {1}", ar1, de1);
        Console.WriteLine("{0} {1}", ar2, de2);
        Console.WriteLine("{0} {1}", ar3, de3);
#endif
        int cost = 0;
        for (int t = 1; t <= 100; t++)              // Check How many cars parked at the same time from t(1) - t(100)
        {
            int parked = 0;                         // Number of parked trucks

            if (ar1 <= t && t < de1)                // Is A parked?
                parked++;

            if (ar2 <= t && t < de2)                // Is B parked?
                parked++;   
           
            if (ar3 <= t && t < de3)                // Is A parked?
                parked++;
            #if DEBUG
            //Console.WriteLine("{0} {1}",parked, t);
            #endif
            if (parked == 1)                       // Calc cumulative cost             
                cost += A;

            if (parked == 2)
                cost += 2 * B;

            if (parked == 3)
                cost += 3 * C;           
        }
        Console.WriteLine(cost);
    }
}