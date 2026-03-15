using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam1; //Az int C#‑ban egy egész szám típus, amely tört vagy tizedesjegy nélküli számokat tud tárolni. 
            int szam2;
            int sum = 0;
            Console.Write("Kérem az első számot:");
            szam1 = Convert.ToInt32(Console.ReadLine()); //de lehetne az órán tanult a int.Parse() is
            Console.WriteLine($"Az első szám értéke: {szam1}");
            Console.Write("Kérem a második számot:");
            szam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A második szám értéke: {szam2}");
            sum = szam1 + szam2;
            Console.WriteLine($"A két szám összege: {sum}");
            Console.ReadKey();

        }
    }
}
