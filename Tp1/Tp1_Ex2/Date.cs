using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Ex2
{
    public class Date
    {
        public readonly static Date Default = new Date(1, 1, 1900);

        public int Jour { get; set; }
        public int Mois { get; set; }
        public int Année { get; set; }

        public Date()
        {

        }

        public Date(int _Jour, int _Mois, int _Année)
        {
            if (_Année >= 1900 && _Mois > 0 && _Mois < 13 && _Jour < 32 && _Jour > 0)
            {
                Année = _Année;
                Jour = _Jour;
                Mois = _Mois;
            }
            else
                throw new Exception("date invalid !");
        }


        public void Afficher()
        {
            try
            {
                if (!IsValid())
                    throw new Exception("date Invalid !");
                Console.WriteLine(this);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool IsValid() => (Année > 1900 && Mois > 0 && Mois < 13 && Jour < 32 && Jour > 0);

        public void Saisir()
        {
            try
            {
                Console.WriteLine("Jour :");
                Jour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mois :");
                Mois = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Année :");
                Année = Convert.ToInt32(Console.ReadLine());
                if (!IsValid())
                    throw new Exception("date Invalid !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool Comparer(Date date) => this.Jour == date.Jour && this.Mois == date.Mois && this.Année == date.Année;

        public bool Comparer(Date date1, Date date2) => date1.Jour == date2.Jour && date1.Mois == date2.Mois && date1.Année == date2.Année;

        public override string ToString() => $"{Jour}/{Mois}/{Année}";
    }
}
