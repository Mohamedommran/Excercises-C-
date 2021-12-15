using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_pt_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            List<int> list = new List<int>()
           {23,25,27,12,9,73};
            
            for (int i = 0; i < list.Count; i++)
            {
                result += list[i];
            }
            Console.WriteLine(result);
        }
    }
}
