using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5_pt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mois;
            Console.WriteLine("Please Choose a Month (1-12)");
            mois = Convert.ToInt32(Console.ReadLine());

            switch (mois)
            {
                case 3: case 4: case 5: 
                    Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
                    break;
                case 6: case 7: case 8:
                    Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
                    break;
                case 9: case 10: case 11:
                    Console.WriteLine("La saison du mois saisi est l'AUTOMNE");
                    break;
                case 1: case 2: case 12:
                    Console.WriteLine("La saison du mois saisi est l'HIVER");
                    break;
            }

        }
    }
}
