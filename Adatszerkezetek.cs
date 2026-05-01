using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Statikus adattároló
            int[] tomb = new int[10];
            for (int i = 0; i < 10; i++)
            { 
                tomb[i] = i; 
            }
            for (int i = 0; i < tomb.Length; i++)
            {  
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine();
            //Dinamikus adattároló
            List<int> Adatok = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Adatok.Add(i);
            }
            for (int i = 0; i < Adatok.Count; i++)
            {
                Console.WriteLine(Adatok[i]);
            }
            Console.ReadKey();
        }
    }
}
//Adattároló típusok
//string[] stringtomb = new string[10];
//bool[] booltomb = new bool[10];