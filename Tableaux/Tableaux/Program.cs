using System;
using System.Collections.Generic;

namespace Tableaux
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Tableaux
            int[] tabDeInts = { 5, 9, 12, 82, 0, 96 };
            tabDeInts[3] = 64;
            Console.WriteLine(tabDeInts[3]);
            MultPar2(tabDeInts);
            foreach(int nb in tabDeInts)
            {
                Console.WriteLine(nb);
            }

            // Listes
            List<string> noms = new List<string>();
            noms.Add("Unity");
            noms.Add("Godot");
            noms.Add("C#");
            noms.Add("Blender");
            noms.Add("Love2D");

            foreach(string s in noms)
            {
                Console.WriteLine(s);
            }

            if(noms.Contains("Unreal"))
            {
                Console.WriteLine("Unity existe dans la liste");
            }
        }

        static void MultPar2(int[] tabDeInts)
        {
            for (int i = 0; i < tabDeInts.Length; i++)
            {
                tabDeInts[i] = tabDeInts[i] * 2;
            }
        }
    }
}
