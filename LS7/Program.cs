using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20._10._26LS7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for (int platz = 1; platz <= 3; platz++)
            // {
            //     Console.WriteLine("Platz " + platz);
            // }

            //for (int Regalnummer = 2; Regalnummer <= 10; Regalnummer+=2)
            //{
            //    Console.WriteLine("Nummer " + Regalnummer);
            //}
            //for (int Regalnummer = 2; Regalnummer <= 14; Regalnummer += 2)
            //{
            //    Console.WriteLine("Nummer " + Regalnummer);
            //}

            //int akku = 3;
            //while (akku > 0)
            //{
            //    Console.WriteLine("Noch " + akku + " Einheiten");
            //    akku--;
            //}

            //int zeit = 5;
            //while (zeit > 0)
            //{
            //    Console.WriteLine("Noch " + zeit + " Sekunden");
            //    zeit--;
            //}
            //
            //Console.WriteLine("Start!!!");

            //int tickets = 1;
            //while (tickets <= 4)
            //{
            //    Console.WriteLine("Ticket " + tickets);
            //    Thread.Sleep(2000);
            //    tickets++;
            //}

            //int auswahl;
            //do
            //{
            //    Console.Write("Wähle 1, 2 oder 3: ");
            //    auswahl = Convert.ToInt32(Console.ReadLine());
            //} while (auswahl < 1 || auswahl > 3);
            //Console.WriteLine("Auswahl gespeichert.");

            int anzahl;
            int offen = 5;
            do
            {
                do
                {
                    Console.Write("Wähle Buch Nummer: ");
                    anzahl = Convert.ToInt32(Console.ReadLine());
                } while (anzahl < 1 || anzahl > 5);
                Console.WriteLine("Buch " + anzahl + " registriert.");
                offen -= 1; // offen = offen - 1;
                Console.WriteLine("Noch " + offen + " offen");
            } while (offen != 0);
            Console.WriteLine("Alle Bücher verarbeitet.");



        }
    }
}
