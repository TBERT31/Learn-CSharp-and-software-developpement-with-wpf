using System;

namespace TD_AventureTexte
{
    /*
        1. Le joueur est dans une forêt. Il peut aller à l'est ou à l'ouest.
            1.1 Si est = Il tombe d'une falaise et perd
            1.2 Si ouest = Il trouve un château
        2. Le joueur est devant le château. Il peut entrer par la porte ou par la fenêtre.
            2.1 Si porte = Le garde l'arrête, il perd
            2.2 Si fenêtre il entre
        3. Le joueur est dans un couloir du château, il a la porte de gauche ou de droite
            3.1 Si gauche = il tombe sur les gardes et perd
            3.2 Si droite, il trouve la princesse et la sauve

        Aller plus loin :
        - Ajouter un inventaire avec une clé ou des objets
        - Ajouter plus de chemins
        - Ajouter un système de score, vie, magie...
    */

    class Program
    {
        static int vie = 3;
        static int or = 10;

        static void Main(string[] args)
        {
            ShowTitle();
            ShowRules();

            Console.WriteLine("Vous êtes dans une forêt. Aller à l'est ou à l'ouest ?");
            string dir = Console.ReadLine();

            Choix1(dir);

            dir = Console.ReadLine();

            Choix2(dir);

            dir = Console.ReadLine();

            Choix3(dir);
        }

        static void ShowTitle()
        {
            Console.WriteLine(" ________  __    __  ________         ______                                   __                                   ");
            Console.WriteLine("|        \\|  \\  |  \\|        \\       /      \\                                 |  \\                                  ");
            Console.WriteLine(" \\$$$$$$$$| $$  | $$ \\$$$$$$$$      |  $$$$$$\\ __     __   ______   _______  _| $$_    __    __   ______    ______  ");
            Console.WriteLine("   | $$    \\$$\\/  $$   | $$         | $$__| $$|  \\   /  \\ /      \\ |       \\|   $$ \\  |  \\  |  \\ /      \\  /      \\ ");
            Console.WriteLine("   | $$     >$$  $$    | $$         | $$    $$ \\$$\\ /  $$|  $$$$$$\\| $$$$$$$\\\\$$$$$$  | $$  | $$|  $$$$$$\\|  $$$$$$\\");
            Console.WriteLine("   | $$    /  $$$$\\    | $$         | $$$$$$$$  \\$$\\  $$ | $$    $$| $$  | $$ | $$ __ | $$  | $$| $$   \\$$| $$    $$");
            Console.WriteLine("   | $$   |  $$ \\$$\\   | $$         | $$  | $$   \\$$ $$  | $$$$$$$$| $$  | $$ | $$|  \\| $$__/ $$| $$      | $$$$$$$$");
            Console.WriteLine("   | $$   | $$  | $$   | $$         | $$  | $$    \\$$$    \\$$     \\| $$  | $$  \\$$  $$ \\$$    $$| $$       \\$$     \\");
            Console.WriteLine("    \\$$    \\$$   \\$$    \\$$          \\$$   \\$$     \\$      \\$$$$$$$ \\$$   \\$$   \\$$$$   \\$$$$$$  \\$$        \\$$$$$$$");
        }

        static void ShowRules()
        {
            // TODO: Afficher instructions du jeu
        }

        static void Choix1(string dir)
        {
            while (dir != "est" || dir != "ouest")
            {
                if (dir == "est")
                {
                    Console.WriteLine("Vous tombez d'une falaise. PERDU !");
                    Environment.Exit(0);
                }
                else if (dir == "ouest")
                {
                    Console.WriteLine("Vous allez à l'ouest. Vous trouvez un château. Entrer par la porte ou par la fenêtre ?");
                    break;
                }
                else
                {
                    Console.WriteLine("Entrez une destination correcte !");
                    dir = Console.ReadLine();
                }
            }
        }

        static void Choix2(string dir)
        {
            if (dir == "porte")
            {
                Console.WriteLine("Le garde vous a vu. PERDU !");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Vous entrez dans le château. Vous êtes dans le couloir. Ouvrir la porte de gauche ou de droite ?");
            }
        }

        static void Choix3(string dir)
        {
            if (dir == "gauche")
            {
                Console.WriteLine("Le garde vous a vu. PERDU !");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Vous trouvez la princesse, bravo !");
            }
        }

        static void ShowInfos()
        {
            Console.WriteLine("Vie = " + vie + " - Or = " + or);
        }
    }
}
