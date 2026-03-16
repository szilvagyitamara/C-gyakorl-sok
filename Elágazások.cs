using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Változó deklarálása
            int ora = 0;
            //bekérés
            Console.Write("Kérek egy óra számot:");
            //ora változó feltöltése a bekért értékkel
            ora=int.Parse(Console.ReadLine());
            //Vizsgálat 1->Reggeli időszak (0-8)
            if (ora >= 0 && ora <= 8)
            {
                Console.WriteLine("Jó reggelt!");
            }
            //Vizsgálat 2->Nap közbeni időszak (8-18)
            else if (ora > 8 && ora <= 18)
            {
                Console.WriteLine("Szép napot!");
            }
            //Vizsgálat 3->Esti időszak (18-24)
            else
            {
                Console.WriteLine("Jó éjszakát!");
            }
            Console.ReadKey();
        }
    }
}
/*Az else if egy köztes lépés az if és az else között.
A program így tud több lehetőség közül választani:
- if → első feltétel
- else if → második, harmadik, negyedik… feltétel
- else → ha egyik feltétel sem igaz*/
