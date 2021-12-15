using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Pt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel as votre age ?");
            int age = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Quel as votre sexe (m & f) ?");
            string sexe = Console.ReadLine();
           

            if (age >= 18 && sexe =="m" )
            
            {
                Console.WriteLine($"Vous êtes un homme et vous êtes majeur..");
            }
            else if (age >= 18 && sexe == "f")
            {
                Console.WriteLine($"Vous êtes une femme et vous êtes majeure.");
            }
            else if (age <= 18 && sexe == "m")
            {
                Console.WriteLine($"Vous êtes un homme et vous êtes mineur.");
            }
            else
            {
                Console.WriteLine($"Vous êtes une femme et vous êtes mineure");
            }
        }
    }
}
