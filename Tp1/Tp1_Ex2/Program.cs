using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Group g = new Group();
            g.Saisie();
            g.Afficher();
            g.Trier();
            g.Afficher();
            Console.ReadKey();
        }
    }
}
