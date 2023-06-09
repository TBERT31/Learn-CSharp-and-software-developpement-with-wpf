using System;
using System.Collections.Generic;
using System.Text;

namespace Classe
{
    class Vehicule
    {
        string couleur;
        int vitesse;

        public Vehicule(string c, int v)
        {
            couleur = c;
            vitesse = v;
        }

        // Set
        public void SetColor(string c)
        {
            couleur = c;
        }

        public void Accelerer(int val)
        {
            vitesse = vitesse + val;
        }

        // Get
        public string GetColor()
        {
            return couleur;
        }

        public int GetSpeed()
        {
            return vitesse;
        }
    }
}
