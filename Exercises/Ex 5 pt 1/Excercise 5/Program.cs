using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Surname");
            string nom = Console.ReadLine();

            Console.WriteLine("Please enter your Name");
            string prenom = Console.ReadLine();

            String date = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine("Bonjour " + nom + " " + prenom + ", nous sommes le " + date + ", comment allez - vous ?"); ;
        }
    }
}
