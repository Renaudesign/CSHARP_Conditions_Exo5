using System;

namespace CSHARP_Conditions_Exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour Utilisateur. Saisir le nom d'un mois. ");
            string mois = Console.ReadLine().ToLowerInvariant();

            switch (mois)
            {
                case "decembre":
                case "janvier":
                case "fevrier":
                    Console.WriteLine("L'HIVER VIENT");
                    break;
                case "mars":
                case "avril":
                case "mai":
                    Console.WriteLine("Le printemps arrive");
                    break;
                case "juin":
                case "juillet":
                case "aout":
                    Console.WriteLine("Janis, range ton spliff et vient chanter Summertime");
                    break;

                default:
                    Console.Write("Echec système : mauvais identifiant ou mot de passe");
                    break;
            }

        }
    }
}
