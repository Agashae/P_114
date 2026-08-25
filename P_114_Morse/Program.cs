using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P_114_Morse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Title();
            UserValue();

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

        static void UserValue()
        {
            string UserValue;
            bool valide;
            do
            {
                Console.WriteLine("Taper votre message: ");
                UserValue = Console.ReadLine();
                valide = true;

                  //pour lire comme un tableau cahque index
                foreach (char check in UserValue)
                {
                    //prend que les lettres non accentues a-z / A-Z
                    if (!((check >= 'a' && check <= 'z') || (check >= 'A' && check <= 'Z')))
                    {
                        valide = false;
                        // ça casse et part vers le message en valide = false
                        break;
                    }
                }

                if (!valide)
                {
                    Console.WriteLine("pas possible car il ya un chiffre, accent, ponctuation ou espace...");

               //https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-10.0
                    // timer de 3 secondes pour ensuite partir dans Main
                    Thread.Sleep(3000);
                    

                }

            } while (!valide);// tant que c'est différent de !valide

            Console.WriteLine(UserValue);
        }

    }
}
