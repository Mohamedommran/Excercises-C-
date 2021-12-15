using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4_pt_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();

            int rand_num = num.Next(1,50);
            while (true) { 
            Console.WriteLine("Choisie Un Nombre (1-50)");
            int choosenNum =Convert.ToInt32(Console.ReadLine());

            if (choosenNum >= rand_num)
            {
                Console.WriteLine("C’est plus petit");
            }
            else if(choosenNum <= rand_num)
            {
                Console.WriteLine("C’est plus grand");      
            }
            else
            {
                Console.WriteLine("Bravo vous avez trouvé !");
                    break;
            }
                        }
        }
    }
}
