using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number ");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            int sum1 = (num_1 + 33);
            int sum2 = (num_2 ++);
            float sumTotal = (float) sum1/(float) sum2;
            Console.WriteLine("the result is " + sumTotal);
        }
    }
}
