using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Level2
{
    /*- Takes userinput and makes a sorted list
      - Exits with "exit" disregarding Caps or blanks
      - Checks that format is ABC-123 and that the number is in between 200 and 500
        M. Ernulf 181220    */
    class Program
    {
        static void Main(string[] args)
        {
            var prodList = new List<string>();
            string text;
            bool terminate = false;
            Console.WriteLine("Skriv in produkter, avsluta med exit ");

            // populate the list
            while (!terminate)
            {
                text = Console.ReadLine();
                text = text.Trim();
                // Check exit
                //string exit = text.ToLower();
                //exit = exit.Trim();
                if (text.Length == 0)
                    WriteMessage("Du får inte ange ett tomt värde");
                else if (text == "exit")
                    terminate = true;
                else 
                    prodList.Add(text);
            }

            //Sort and print the list
            prodList.Sort();
            Console.WriteLine("Du angav följande produkter (sorterade) :");
            foreach (var product in prodList)
            {
                Console.WriteLine("* " + product);
            }
            Console.ReadLine();
        }
    
        static void WriteMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}