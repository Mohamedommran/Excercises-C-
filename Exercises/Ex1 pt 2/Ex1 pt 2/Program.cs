using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_pt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool rainy = true;
            if (rainy)
            {
                Console.WriteLine("Bonjour, il pleut aujourd’hui, vous devriez prendre votre parapluie.");
            }
            else
            {
                Console.WriteLine("Bonjour, il ne pleut pas aujourd’hui, bonne journée.");
            }
        }
    }
}
