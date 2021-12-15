using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_pt_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[6] { "lundi", "mardi", "mercerdi", "jedi", "venderdi", "samedi" };
            Console.WriteLine(" le contenu de l’indice 1 et 4 du tableau est " + days[0] + " et " + days[3]);
            Console.WriteLine(" le contenu du 1er et du 4eme élément du tableau est " + days[1] + " et " + days[4]);

            days[3] = ("jeudi");
            Array.Resize(ref days, days.Length + 1);

            days[6] = "dimanche";
            Console.WriteLine("les jours de semaine sont:");
            Array.ForEach(days, Console.WriteLine);


        }
    }
}
