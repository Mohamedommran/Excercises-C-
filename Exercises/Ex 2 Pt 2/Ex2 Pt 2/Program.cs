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
            Console.WriteLine("Quel as votr age ?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine($"Vous avez {age} ans, vous êtes donc majeur.e.");
            }
            else 
            {
                Console.WriteLine($"Vous avez {age} ans, vous êtes donc mineur.e.");
            }
        }
    }
}
