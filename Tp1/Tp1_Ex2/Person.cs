using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Ex2
{
    public class Person
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public Date DateDeNaissance { get; set; }

        public Person()
        {

        }

        public Person(string _Prenom="",string _Nom="",Date _DateDeNaissance = null) 
        {
            Prenom = _Prenom;
            Nom = _Nom;
            DateDeNaissance = _DateDeNaissance;
        }

        public virtual void Saisir()
        {
            Console.WriteLine("Prénom :");
            Nom = Console.ReadLine();
            Console.WriteLine("Nom :");
            Prenom = Console.ReadLine();
            DateDeNaissance = new Date();
            DateDeNaissance.Saisir();
        }

        public virtual void Afficher() => Console.WriteLine(this);

        public override string ToString() => $"{Nom} {Prenom}  -  {DateDeNaissance.ToString()}";
    }
}
