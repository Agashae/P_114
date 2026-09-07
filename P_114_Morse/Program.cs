using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using static System.Net.Mime.MediaTypeNames;

namespace P_114_Morse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Title();

            Console.WriteLine("Que voulez-vous faire ? 1 pour les règles et 2 pour le morse et autre pour quitter");

            ConsoleKey menu;
            bool isTrue = true;

            do
            {
                menu = Console.ReadKey().Key;

                // D1 et D2 pour les 1 et 2 du clavier
                if (menu == ConsoleKey.D1)
                {
                    Rules();
                }
                else if (menu == ConsoleKey.D2)
                {
                    Value();
                }
                else
                {
                    Environment.Exit(0);
                }

            } while (isTrue);



            // pour enlever message console
            Console.ReadLine();
        }

        static void Title()
        {
            Console.WriteLine("╔═════════════ Agashae Premakumar ══════════════════════════╗");
            Console.WriteLine("║                                                           ║");
            Console.WriteLine("║    Bienvenue dans le jeu : 114 Codification Chiffrement   ║");
            Console.WriteLine("║                                                           ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝\n");
        }

        static void Value()
        {

            Console.Clear();

            Title();

            string UserValue;
            bool valide;
            do
            {
                Console.WriteLine("Taper votre message (sans accents): ");
                UserValue = Console.ReadLine();
                valide = true;

                //pour lire comme un tableau cahque index
                foreach (char check in UserValue)
                {
                    //prend que les lettres non accentues a-z / A-Z
                    if (!((check >= 'a' && check <= 'z') ||
                          (check >= 'A' && check <= 'Z') ||
                          (check >= '0' && check <= '9') ||
                          (check == ' ')))

                    {
                        valide = false;
                        // ça casse et part vers le message en valide = false
                    }
                }

                if (!valide)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("pas possible car il ya un chiffre, accent, ponctuation...");
                    Console.ResetColor();

                    //https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-10.0
                    // timer de 1 seconde pour ensuite partir dans Main
                    Thread.Sleep(1000);
                }

            } while (!valide);// tant que c'est différent de !valide


            // tableau 2 dimensions
            // https://enseignement.section-inf.ch/moduleICT/319/Tableaux/Introduction/
            // https://fr.wikipedia.org/wiki/Code_Morse_international
            string[,] morseTableau = new string[,] {
            { "A", ".-" }, { "B", "-..." }, { "C", "-.-." }, { "D", "-.." },
            { "E", "." }, { "F", "..-." }, { "G", "--." }, { "H", "...." },
            { "I", ".." }, { "J", ".---" }, { "K", "-.-" }, { "L", ".-.." },
            { "M", "--" }, { "N", "-." }, { "O", "---" }, { "P", ".--." },
            { "Q", "--.-" }, { "R", ".-." }, { "S", "..." }, { "T", "-" },
            { "U", "..-" }, { "V", "...-" }, { "W", ".--" }, { "X", "-..-" },
            { "Y", "-.--" }, { "Z", "--.." }, { " ", "/" },
            { "0", "-----" }, { "1", ".----" }, { "2", "..---" }, { "3", "...--" },
            { "4", "....-" }, { "5", "....." }, { "6", "-...." }, { "7", "--..." },
            { "8", "---.." }, { "9", "----." }
            };

            Console.ForegroundColor = ConsoleColor.Green;

            //UserValue c'est un string et c'est aussi un tableau
            foreach (char a in UserValue)
            {
                //GetLength() pour connaître la taille du morseTableau
                //c'est genre la dimension 0
                for (int i = 0; i < morseTableau.GetLength(0); i++)
                {
                    // ToUpper transforme tout en majuscule
                    if (char.ToUpper(a) == morseTableau[i, 0][0])
                    {
                        Console.Write(morseTableau[i, 1] + " ");
                        break;
                    }
                }
            }
            Console.ResetColor();

            Console.Write("\n\nVoulez-vous refaire? (O ou une autre touche pour non) :");
            ConsoleKey restart = Console.ReadKey().Key;

            // P_Prog 319
            if (restart == ConsoleKey.O)
            {
                Console.Clear();
                Title();
                Value();
            }
            else
            {
                Environment.Exit(0);
            }
        }


        static void Rules()
        {
            Console.Clear();

            Console.WriteLine("Ici, il y a les règles !\n");

            Console.WriteLine("Voici la table de conversion : ");
            Console.WriteLine("A = .- B = -... C = -.-. D = -.. E = . F = ..-.G = --. H = ....");
            Console.WriteLine("I = .. J = .--- K = -.- L = .-.. M = -- N = -. O = --- P = .--. Q = --.- R = .-. S = ... T = - U = ..- V = ...-");
            Console.WriteLine("W = .-- X = -..- Y = -.-- Z = --.. ESPACE = /");
            Console.WriteLine("0 = ----- 1 = .---- 2 = ..--- 3 = ...-- 4 = ....- 5 = ..... 6 = -.... 7 = --... 8 = ---.. 9 = ----.\n\n");


            Console.WriteLine("Voici un exemple qui marche");

            // @ pour tout prendre en un contenu
            Console.WriteLine(@"╔═════════════ Agashae Premakumar ══════════════════════════╗
║                                                           ║
║    Bienvenue dans le jeu : 114 Codification Chiffrement   ║
║                                                           ║
╚═══════════════════════════════════════════════════════════╝
Taper votre message (sans accents) :
Agashae");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(".- --. .- ... .... .- .");
            Console.ResetColor();

            Console.WriteLine("Voulez-vous refaire ? (O ou une autre touche pour non) :");

            Console.WriteLine("\nVoici un exemple qui ne marche pas");

            Console.WriteLine(@"╔═════════════ Agashae Premakumar ══════════════════════════╗
║                                                           ║
║    Bienvenue dans le jeu : 114 Codification Chiffrement   ║
║                                                           ║
╚═══════════════════════════════════════════════════════════╝
        Taper votre message (sans accents) :
        é");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pas possible car il y a un chiffre, un accent ou une ponctuation.");
            Console.ResetColor();

            Console.WriteLine("Voulez-vous refaire ? (O ou une autre touche pour non) :\n\n");


            Console.WriteLine("Prêt à jouer? Taper Escape");

            ConsoleKey readyPlay;
            bool isTrue = true;

            do
            {
                readyPlay = Console.ReadKey().Key;

                // D1 et D2 pour les 1 et 2 du clavier
                if (readyPlay == ConsoleKey.Escape)
                {
                    // commande car args n'existe pas dans mon contexte actuelle
                    string[] args = null;
                    Main(args);
                }
            } while (isTrue);


        }


    }

}

