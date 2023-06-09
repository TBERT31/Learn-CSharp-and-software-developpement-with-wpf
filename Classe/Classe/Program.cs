using System;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto m1 = new Moto("Rouge", 0);
            Moto m2 = new Moto("Blanc", 0);

            Console.WriteLine("Couleur m1 = " + m1.GetColor());
            Console.WriteLine("Couleur m2 = " + m2.GetColor());

            Voiture v1 = new Voiture("Blanc", 10, 2);
            v1.DeclencherAirbags();
            Console.WriteLine("Vitesse v1 = " + v1.GetSpeed());
            v1.Accelerer(40);
            Console.WriteLine("Vitesse v1 = " + v1.GetSpeed());
        }
    }
}
