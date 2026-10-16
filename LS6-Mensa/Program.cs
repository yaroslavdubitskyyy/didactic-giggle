using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._09._2026PraxisfallMensa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Artikelname;
            decimal rabatt = 0;

            Console.WriteLine("Was willst du kaufen?");
            Artikelname = Console.ReadLine();
            Console.WriteLine("Wie viel kostet es?");
            decimal Preis = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Wie viel willst du kaufen?");
            int Menge = Convert.ToInt32(Console.ReadLine());
            if (Menge < 1)
            {
                Console.WriteLine("Fehler: die Menge ist kleiner als 1");
                return;
            }
           

                decimal Zwischenresultat = ((Preis) * (Menge));
                if (Menge == 1 || Menge == 2)
                {
                    Console.WriteLine("Dein " + Menge + " " + Artikelname + " kostet: " + ((Preis) * (Menge)));
                }
                if (Menge == 3 || Menge == 4)
                {
                    rabatt = 10;
                    Console.WriteLine("Dein " + Menge + " " + Artikelname + " mit Rabatt" + " kostet: " + ((Zwischenresultat / 100) * (100 - rabatt)));
                }
                if (Menge >= 5)
                {
                    rabatt = 20;
                    Console.WriteLine("Dein " + Menge + " " + Artikelname + " mit Rabatt" + " kostet: " + ((Zwischenresultat / 100) * (100 - rabatt)));
                }
            

        }
    }
}
