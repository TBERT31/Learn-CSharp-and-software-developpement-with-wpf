using System;

namespace Conditions
{
    class Program
    {
        static float solde = 100;
        static int age = 1;
        static string nom = "tuto";

        static void Main(string[] args)
        {
            /*Console.WriteLine("Age = " + age);
            if(age >= 18 && solde > 0)
            {
                Console.WriteLine("Majeur, solde > 0");
            }
            else if(age > 18 && solde <= 0)
            {
                Console.WriteLine("Majeur, solde < 0");
            }
            else
            {
                Console.WriteLine("Mineur");
            }*/

            if(age == 1 || age == 2)
            {

            }

            switch (age)
            {
                case 1:
                    Console.WriteLine("1 an");
                    break;
                case 2:
                    Console.WriteLine("2 ans");
                    break;
                case 3:
                    Console.WriteLine("3 ans");
                    break;
                case 4:
                    Console.WriteLine("4 ans");
                    break;
                // ...
                default:
                    Console.WriteLine("autre");
                    break;
            }

            if (nom != "toto")
            {
                Console.WriteLine("nom PAS EGAL toto");
            }

            Console.WriteLine("Solde = " + solde);
            AcheterProduit(50);
            Console.WriteLine("Solde = " + solde);
            AcheterProduit(10);
            Console.WriteLine("Solde = " + solde);
            AcheterProduit(50);
            Console.WriteLine("Solde = " + solde);
        }

        static void AcheterProduit(float prix)
        {
            if(solde >= prix)
            {
                solde = solde - prix;
            }
            else
            {
                Console.WriteLine("Solde insuffisant !");
            }

            /*string nb = Console.ReadLine();
            if(nb != "")
            {

            }*/
        }
    }
}
