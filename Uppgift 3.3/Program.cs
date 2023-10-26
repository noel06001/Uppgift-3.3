using System;

namespace Uppgift_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int timmar = int.Parse(Console.ReadLine());

            int pris = timmar * 80;
            
            if (pris > 950)
            {
                Console.WriteLine("Tyvär så överskrider detta den maximala hyran per dag." + " (950kr)");

            }
            else
            {
                Console.WriteLine("Den totala hyran blir " +  pris + "kr");
            }
            Console.ReadKey();
        }
    }
}

