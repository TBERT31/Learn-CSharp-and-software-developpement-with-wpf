using System;

namespace Boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("Coucou " + i);
            }

            int j = 1;
            while(j < 100)
            {
                Console.WriteLine("Test " + j);
                // ...
                j++;
            }

            Console.WriteLine("Quel est le résultat de 3 + 4 ?");
            string res = Console.ReadLine();
            while (res != "7")
            {
                Console.WriteLine("Essaye encore !");
                res = Console.ReadLine();
            }
            Console.WriteLine("Bravo !");
        }
    }
}
