using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6_pt_4
{
    internal class Program
    {
        enum days
        {
            Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche
        }
        static void Main(string[] args)
        {
            foreach (string day in Enum.GetNames(typeof(days)))
            {
                Console.WriteLine(day);
            }
            days jour4 = days.Jeudi;
            Console.WriteLine("la valeur 4 de l’énumération week" + jour4);
        }
    }
}
