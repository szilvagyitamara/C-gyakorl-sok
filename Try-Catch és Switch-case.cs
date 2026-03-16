using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tanuló informatika jegye:");
            int jegy = int.Parse(Console.ReadLine());
            switch (jegy)
            {
                case 5:
                    {
                        Console.WriteLine("Jeles");
                        break;
                    }
            
                case 4:
                    {
                        Console.WriteLine("Jó");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Közepes");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Elégséges");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Elégtelen");
                        break;
                    }
                default:
                    Console.WriteLine("Nincs ilyen osztályzat!");
                    break;

            }
        Console.ReadKey();
        
        /*
        try
        {
            Console.WriteLine("Kérek egy számot:");
            int szam=int.Parse(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot:");
            int szam2 = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Há hülye vagy fönök!Ez nem szám!");
        }*/

    }
    }
}
