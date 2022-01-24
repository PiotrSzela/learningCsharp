using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many numbers you want to check:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[a];

            Console.WriteLine($"give me {a} numbers:");

            for (int i = 0; i < a; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine()); // add number until tab[i] < a
            }

            Array.Sort(tab);
            Console.WriteLine("even numbers:");
            for (int i = 0; i < tab.Length; i++)


                if (tab[i] % 2 == 0)
                    Console.Write($"{tab[i]}, ");

            Console.WriteLine("\n odd numbers:");

            for (int i = 0; i < tab.Length; i++)

                if (tab[i] % 2 == 1)
                    Console.Write($"{tab[i]}, ");




            Console.ReadKey();
        }
    }
}
