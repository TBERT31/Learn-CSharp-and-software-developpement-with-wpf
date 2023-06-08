using System;

namespace Fonctions
{
    class Program
    {
        static string nom = "Cardinale";

        static void Main(string[] args)
        {
            Console.WriteLine("Lancement du programme");
            DireBonjour();
            ModifierNom();
            DireBonjourAvecParam("Anthony");
            Console.WriteLine("3 + 5 = " + Calculer(3, 5));
            Console.WriteLine("9 + 2 = " + Calculer(9, 2));
            Console.WriteLine("1 + 568 = " + Calculer(1, 568));
        }

        static void DireBonjour()
        {
            Console.WriteLine("Bonjour !");
        }

        static void DireBonjourAvecParam(string prenom, string nom = "Tutu")
        {
            Console.WriteLine("Bonjour " + prenom + " " + nom);
        }

        static int Calculer(int nb1, int nb2)
        {
            int resultat = 0;
            resultat = nb1 + nb2;
            return resultat;
        }

        static void ModifierNom()
        {
            nom = "Toto";
        }
    }
}
