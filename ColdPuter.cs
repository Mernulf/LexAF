using System;

public class Coldputer
{
    public static void Main(string[] args)
    {
        int l = Convert.ToInt32(Console.ReadLine());        //length
        string[] temps = Console.ReadLine().Split(' ');     //Create array of temperature strings separated by space
        int minuscount = 0;                                 //Init minuscount  
        foreach (string s in temps)
            if (s[0] == '-')
                minuscount++;
        Console.WriteLine(minuscount);
    }
}
