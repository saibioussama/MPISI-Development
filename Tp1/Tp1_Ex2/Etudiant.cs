using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Ex2
{
    public class Etudiant : Person
    {
        public string Institution { get; set; }
        public int TD { get; set; }

        public Etudiant()
        {

        }

        public Etudiant(string _Nom = "",string _Prenom="",Date _DateDeNaissance = null ,string _Institution = "",int _TD=1) 
            : base(_Prenom:_Prenom,_Nom:_Nom,_DateDeNaissance:_DateDeNaissance)
        {
            Institution = _Institution;
            TD = _TD;
        }

        public override void Saisir()
        {
            base.Saisir();
            Console.WriteLine("Institution :");
            Institution = Console.ReadLine();
            Console.WriteLine("TD :");
            TD = Convert.ToInt32(Console.ReadLine());
        }

        public override void Afficher()
        {
            Console.WriteLine(base.ToString());
            Console.WriteLine($"Instituion : {Institution}");
            Console.WriteLine($"TD : {TD}");
        }

    }
}
