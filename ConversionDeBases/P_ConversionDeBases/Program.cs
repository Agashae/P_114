using System;

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
            Console.WriteLine("C'est "+ChoiceConversion);

            if (ChoiceConversion == 1)
            {
             
            }
            else if (ChoiceConversion == 2) { }
            else if (ChoiceConversion == 3) { }
            else if (ChoiceConversion == 4) { }

                string UserValue = Console.ReadLine();
            Console.WriteLine(UserValue);

        }
    }
}
