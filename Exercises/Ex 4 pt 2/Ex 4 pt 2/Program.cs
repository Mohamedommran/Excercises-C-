using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4_pt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int motdedpassc = 123456;
            string username = "admin";
            Console.WriteLine("identifiant : ");
            string id = (Console.ReadLine());
            Console.WriteLine("Mot De Pass : ");
            int motDePass = Convert.ToInt32(Console.ReadLine());

            switch (motDePass)
            {
                    case int vrai when (motDePass == motdedpassc && id == username):

                    Console.WriteLine("Bienvenue à la Manu.");
                    break;

                    case int faut when (motDePass != motdedpassc || id != username):
                    Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
                    break;
            }

              

        }
    }
}
