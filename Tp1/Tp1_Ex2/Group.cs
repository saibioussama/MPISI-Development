using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Ex2
{
    public class Group
    {
        private Etudiant[] _Group = new Etudiant[100];
        public int Count { get; set; } = 0;

        public Etudiant this[int index]
        {
            get => _Group[index];
            set => _Group[index] = value;
        }

        public void Saisie()
        {
            if (Count > _Group.Length)
                throw new Exception();
            string s;
            do
            {
                Etudiant e = new Etudiant();
                e.Saisir();
                _Group[Count++] = e;
                do
                {
                    Console.WriteLine("s: stop \na: ajout");
                    s = Console.ReadLine();
                } while (s != "s" && s != "a");
            } while (s == "a");
        }

        public void Afficher()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("***********************************************");
            for (int i = 0; i < Count; i++)
            {
                _Group[i].Afficher();
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("***********************************************");
            Console.WriteLine("===============================================");
        }

        public void Trier()
        {
           _Group = _Group.Where(e=>e!=null)
                .OrderByDescending(e => e.DateDeNaissance.Année)
                .ThenByDescending(e => e.DateDeNaissance.Mois)
                .ThenByDescending(e => e.DateDeNaissance.Jour)
                .ToArray();
        }

    }
}
