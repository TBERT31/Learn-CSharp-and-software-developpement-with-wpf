using System;

namespace Variables
{
    class Program
    {
        // Variables

        // Fonctions
        static void Main(string[] args)
        {
        	// 4 variables
            string name;
            int age;
            float score;
            bool active = false;

            // Utilisation et affichage des variables
            name = "Anthony";
            name = name + " Cardinale";
            Console.WriteLine("Hello " + name);
            age = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Age = " + age);
        }


    }
}
