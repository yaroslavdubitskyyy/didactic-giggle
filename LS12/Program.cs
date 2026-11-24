using System;

namespace CampusKontrollzentrum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anwesend = 0;
            int kapazitaet = 12; // Ausgangswert; in LS12 soll er geändert werden können.
            int auswahl;

            do
            {
                Console.WriteLine("\nCampus-Kontrollzentrum");
                Console.WriteLine("1 = Einlass");
                Console.WriteLine("2 = Ausgang");
                Console.WriteLine("3 = Status");
                Console.WriteLine("4 = Kapazität ändern");
                Console.WriteLine("0 = Ende");
                Console.Write("Auswahl: ");
                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {
                    Console.Write("Gruppengrösse: ");
                    int gruppe = Convert.ToInt32(Console.ReadLine());
                    if (gruppe > 0 && gruppe <= kapazitaet - anwesend)
                    {
                        anwesend = anwesend + gruppe;
                        Console.WriteLine("Einlass erfolgreich.");
                    }
                    else
                    {
                        Console.WriteLine("Einlass abgelehnt.");
                    }
                }
                else if (auswahl == 2)
                {
                    Console.Write("Gruppengrösse: ");
                    int gruppe = Convert.ToInt32(Console.ReadLine());
                    if (gruppe > 0 && gruppe <= anwesend)
                    {
                        anwesend = anwesend - gruppe;
                        Console.WriteLine("Ausgang erfolgreich.");
                    }
                    else
                    {
                        Console.WriteLine("Ausgang abgelehnt.");
                    }
                }
                else if (auswahl == 3)
                {
                    Console.WriteLine("Anwesend: " + anwesend);
                    Console.WriteLine("Kapazität: " + kapazitaet);
                    Console.WriteLine("Freie Plätze: " + (kapazitaet - anwesend));
                }

                else if (auswahl == 4)
                {
                    Console.Write("Neue kapazitaet: ");
                    int neueKapazitaet = Convert.ToInt32(Console.ReadLine());

                    if (neueKapazitaet >= 1 &&
                        neueKapazitaet <= 12 &&
                        neueKapazitaet >= anwesend)
                    {
                        kapazitaet = neueKapazitaet;
                        Console.WriteLine("Kapazität erfolgreich geändert.");
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Auswahl");
                    }
                }
            
                else if (auswahl == 0)
                {
                    Console.WriteLine("Programm beendet.");
                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl.");
                }
            } while (auswahl != 0);
        }
    }
}
