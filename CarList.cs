using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace CarList
{

    class Program
    {
        // Added to play with Globalization
        /*public static string GetCurrencySymbol(string code)
        {
            System.Globalization.RegionInfo regionInfo = (from culture in CultureInfo.GetCultures(System.Globalization.CultureTypes.InstalledWin32Cultures)
                                                          where culture.Name.Length > 0 && !culture.IsNeutralCulture
                                                          let region = new System.Globalization.RegionInfo(culture.LCID)
                                                          where String.Equals(region.ISOCurrencySymbol, code, StringComparison.InvariantCultureIgnoreCase)
                                                          select region).First();

            return regionInfo.CurrencySymbol;
        }*/

        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() 
            {
                new Car() { Make = "Ford",     Model =  "F50",      Price = "1000", Currency = "PLN", Year = "2009"},
                new Car() { Make = "Toyota",  Model =   "Auris",    Price = "5000", Currency = "JPY", Year = "2019"},
                new Car() { Make = "Volvo",   Model =   "XC60",     Price = "3000", Currency = "SEK", Year = "2021"},
                new Car() { Make = "Lotus",   Model =   "Esprit",   Price = "7000", Currency = "GPB", Year = "1984"},
                new Car() { Make = "Volvo",   Model =   "242GL",    Price = "500",  Currency = "DKK", Year = "1978"}
            };

            //foreach (var value in myCars)
            //{
                //add currency symbol after price (not every symbol works with Globalization)
                //string symbol = GetCurrencySymbol("USD");
            //Console.WriteLine(symbol);
            //    Console.WriteLine(value.Make.PadRight(12) + value.Model.PadRight(12) + value.Price.PadRight(5) + symbol.PadRight(12) + value.Currency.PadRight(12) + value.Year);
            //};

            List<Car> sortedList = myCars.OrderByDescending(Car => Car.Year).ToList();

            sortedList.ForEach(car => Console.WriteLine(car.Make.Trim().PadRight(10) + car.Model.Trim().PadRight(10) +
                car.Price.Trim().PadRight(5) + /*car.symbol.PadRight(12) +*/ car.Currency.Trim().PadRight(10) + car.Year));
            Console.ReadLine();
        }
    }
    
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }
        public string Currency { get; set; }
        public string Year  { get; set; }        
    }
}
