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

            Console.WriteLine("Was willst du kaufen?");
            Artikelname = Console.ReadLine();
            //Console.WriteLine(Artikelname);
            Console.WriteLine("Wie viel kostet es?");
            decimal Preis = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Wie viel willst du kaufen?");
            int Menge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dein " + Menge + " " + Artikelname + " kostet: " + ((Preis)*(Menge)));
        }
    }
}
