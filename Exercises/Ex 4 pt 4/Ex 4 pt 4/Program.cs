using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4_pt_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int multiNum = 1;
            string Choice;
            do
            {
                Console.WriteLine("Vous Souhaitez multiplier des nombre(O,N) ?");
                Choice = Console.ReadLine();

                if (Choice == "o")
                {
                    Console.WriteLine("Entre votre nombre!");
                    int Num1 = Convert.ToInt32(Console.ReadLine());
                    numbers.Add(Num1);
                    multiNum = Num1 * multiNum;
                }
            }
            while (Choice == "o");

            Console.WriteLine("le resultat est " + multiNum);


        }
    }
}
