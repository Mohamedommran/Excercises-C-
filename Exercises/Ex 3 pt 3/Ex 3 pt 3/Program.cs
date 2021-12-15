using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3_pt_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Ajouter un Nombre");
            int num = Convert.ToInt32(Console.ReadLine());
            while (true) {
                Console.WriteLine("Vous voulez ajouter un nombre ? (O,N)");
                string answer =Console.ReadLine();
                if (answer == "o") 
                {
                    Console.WriteLine("Ajouter un nombre");
                    int autreNum = Convert.ToInt32(Console.ReadLine());
                    num+= autreNum ;

                }
                else if (answer == "n") 
                {
                    result = num;
                    Console.WriteLine($"le resultat est "+ result);
                    break;
                }
                
            
            }

          

        }
    }
}
