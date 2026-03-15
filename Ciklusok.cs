using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0; //A double lebegőpontos szám típus tizedesjegyeket is képes tárolni
            double atlag = 0;
            double szorzat = 1;
            for (int i = 0; i <= 10; i++) // for — számlálás alapú ismétlés, amikor tudjuk, hányszor kell futnia.

            {
                sum += i;
            }
            atlag = sum / 10;
            int j= 1;
            while (j <= 10) // while — feltétel alapú ismétlés, amikor csak azt tudjuk, hogy meddig kell futnia.

            {
                szorzat =szorzat * j;
                j++;
            }
            Console.WriteLine("A számok összege: ");
            Console.WriteLine(sum);
            Console.WriteLine("A számok átlaga: ");
            Console.WriteLine(atlag);
            Console.WriteLine("A számok szorzata:");
            Console.WriteLine(szorzat);
            Console.ReadKey(); // megállítja a program futását, és vár egy billentyű lenyomására, mielőtt továbbmenne vagy bezáródna a konzolablak.

        }
    }
}
