using System;
using System.Linq.Expressions;

namespace P_ConversionDeBases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title();

            int choiceConversion = 0;

            while (true)
            {
                Console.Write("Votre choix (1-4) : ");
                try
                {
                    choiceConversion = int.Parse(Console.ReadLine());

                    if (choiceConversion >= 1 && choiceConversion <= 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("C'est bien un chiffre mais pas entre 1 et 4");
                    }
                }
                catch
                {
                    Console.WriteLine("Ce n'est pas valide");
                }
            }

            TitleChoices(choiceConversion);


            Console.ReadLine();
        }

        static void Title()
        {
            Console.WriteLine("Mettez en pleine écran pour une meilleure expérience");
            Console.WriteLine("╔═════════════ Agashae Premakumar ══════════════════════════╗");
            Console.WriteLine("║                                                           ║");
            Console.WriteLine("║    Bienvenue dans le jeu : 114 Codification Chiffrement   ║");
            Console.WriteLine("║            Ici c'est les conversiones de bases            ║");
            Console.WriteLine("║                                                           ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝\n");
            Console.WriteLine("Taper un numéro entre 1-4 pour un choix\n");

            Console.WriteLine("1. Décimal > Binaire");
            Console.WriteLine("2. Binaire > Décimal");
            Console.WriteLine("3. Binaire > Octal");
            Console.WriteLine("4. Octal > Binaire");



        }
        //https://enseignement.section-inf.ch/moduleICT/319/Methodes/AP_SR/
        static void TitleChoices(int ChoiceConversion)
        {

            if (ChoiceConversion == 1)
            {
                int userDeci = -1; // pour que le while le voit
                bool valide = false;

                do
                {
                    Console.Write("Entrez un nombre décimal (positif) : ");
                    try
                    {
                        userDeci = int.Parse(Console.ReadLine());

                        if (userDeci >= 0)
                        {
                            valide = true;
                        }
                        else
                        {
                            Console.WriteLine("Le nombre doit être positif");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ce n'est pas un nombre valide");
                    }
                }
                while (valide == false);// tant que c'est pas bon

                // successives  2
                int copie = userDeci;
                string binaire = "";

                if (copie == 0)
                {
                    binaire = "0";
                }

            //https://stackoverflow.com/questions/2386325/c-sharp-divide-two-binary-numbers
                while (copie > 0)
                {
                    binaire = (copie % 2) + binaire;
                    copie = copie / 2;
                }

                Console.WriteLine(userDeci + " en binaire = " + binaire);
            }
            else if (ChoiceConversion == 2) { }
            else if (ChoiceConversion == 3) { }
            else if (ChoiceConversion == 4) { }

                string UserValue = Console.ReadLine();
            Console.WriteLine(UserValue);

        }
    }
}
