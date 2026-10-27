using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._10._26LS8KN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int Menge;
            do
            {
                Console.Write("Gib Menge ein: ");
                Menge = Convert.ToInt32(Console.ReadLine());
            } while (!(Menge > 0));
            */

            int menge = 4;
            for (int i = 1; i <= menge; i++)
            {
                Console.WriteLine($"Etikett {i}");
            }
        }
    }
}
