using System;
using System.Collections.Generic;
using System.Text;

namespace Classe
{
    class Moto : Vehicule
    {
        public Moto(string c, int v) : base(c, v)
        {
            Console.WriteLine("Moto créée");
        }
    }
}
