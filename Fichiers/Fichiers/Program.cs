using System;
using System.IO;

namespace Fichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Exemple de texte à écrire dans un fichier sur le disque";
            File.WriteAllText("test.txt", txt);
            string leTexte = "";
            leTexte = File.ReadAllText("test.txt");
            Console.WriteLine("Contenu du fichier = " + leTexte);
        }
    }
}
