using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        public struct enekes
        {
            public string keresztnev;
            public string vezeteknev;
            public int eletkor;
            public bool ferfie;
        }
        static void Main(string[] args)
        {
            enekes Enekes = new enekes();
            Enekes.eletkor = 25;
            Enekes.keresztnev = "Hyunjin";
            Enekes.vezeteknev = "Hwang";
            Enekes.ferfie = true;
            Console.WriteLine($"{Enekes.keresztnev} életkora:{Enekes.eletkor}");
            Console.WriteLine();
            enekes[] Enekesek = new enekes[8];
            Enekesek[0].vezeteknev = "Bang";
            Enekesek[0].keresztnev = "Chan";
            Enekesek[0].eletkor = 28;
            Enekesek[1].vezeteknev = "Lee";
            Enekesek[1].keresztnev = "Minho";
            Enekesek[1].eletkor = 27;
            Enekesek[2].vezeteknev = "Seo";
            Enekesek[2].keresztnev = "Changbin";
            Enekesek[2].eletkor = 26;
            Enekesek[3].vezeteknev = "Hwang";
            Enekesek[3].keresztnev = "Hyunjin";
            Enekesek[3].eletkor = 26;
            Enekesek[4].vezeteknev = "Han";
            Enekesek[4].keresztnev = "Jisung";
            Enekesek[4].eletkor = 25;
            Enekesek[5].vezeteknev = "Lee";
            Enekesek[5].keresztnev = "Felix";
            Enekesek[5].eletkor = 25;
            Enekesek[6].vezeteknev = "Kim";
            Enekesek[6].keresztnev = "Seungmin";
            Enekesek[6].eletkor = 25;
            Enekesek[7].vezeteknev = "Yang";
            Enekesek[7].keresztnev = "Jeongin";
            Enekesek[7].eletkor = 25;

            for (int i = 0; i < Enekesek.Length; i++)
            {
                Console.WriteLine($"{Enekesek[i].keresztnev} {Enekesek[i].vezeteknev} életkora: {Enekesek[i].eletkor}");
            }
        }
    }
}
