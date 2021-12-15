using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2_pt_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> langs = new List<string>() {
                "Html", "Css", "Javacrit", "Jquery", "Php", "Bootstrap", "Java"};

            foreach (var lang in langs)
                Console.WriteLine(lang);

            Console.WriteLine(" le 4ème élément de la liste" + langs[3]);
            Console.WriteLine("l’élément à l’index 4 de la liste"+langs[4]);
            langs.RemoveAt(5);
            langs[2] = "javascript";
            langs.Add("c");
            foreach(var lang in langs)
            {
                Console.WriteLine(lang);
            }
        }
    }
}
