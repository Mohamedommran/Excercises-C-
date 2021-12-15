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

            Console.WriteLine("Please enter your year of Birth");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int age = 2021 - yearOfBirth;

            Console.WriteLine("Fiches de renseignement");
            Console.WriteLine("Nom : "+ nom);
            Console.WriteLine("Prenom : "+prenom);
            Console.WriteLine("Age : "+age);
        }
    }
}
