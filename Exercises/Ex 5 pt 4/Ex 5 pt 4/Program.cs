using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5_pt_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] fujita = new string[6, 2] { { "f0", "Dégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres." },
             {"f1", "Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés."  },
             {"f2","Dégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées."},
             {"f3","Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts| importants, les forêts et les récoltes sont abattues."},
             {"f4","Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent ; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances."},
             {"f5","Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits (parfois surnommé « le doigt de Dieu »." } };

            Console.WriteLine("Il faut renseigner le type d’une tornade");
            string fchoice = Console.ReadLine();
            
            switch (fchoice)
            {
                case "f0":
                    Console.WriteLine(fujita[0,1]);
                    break;
                case "f1":
                    Console.WriteLine(fujita[1,2]);
                    break ;
                case "f2":
                    Console.WriteLine(fujita[2,2]);
                    break;
                case "f3":
                    Console.WriteLine(fujita[3,1]);
                    break;
                case "f4":
                    Console.WriteLine(fujita[4,1]);
                    break;
                case "f5":
                    Console.WriteLine(fujita[5,1]);
                    break;
            }

        }
    }
}
