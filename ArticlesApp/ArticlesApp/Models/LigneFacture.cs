using ArticlesApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesApp.Models
{
    public class LigneFacture
    {
        public int Id { get; set; }
        public int IdArticle { get; set; }
        public int IdFacture { get; set; } 
        public int Quantite { get; set; }
        public float PrixUnitaire { get; set; }

        public LigneFacture()
        {

        }

        public LigneFacture(FactureLigneViewModel item)
        {
            Id = item.Id;
            IdArticle = item.IdArticle;
            IdFacture = item.IdFacture;
            Quantite = item.Quantite;
            PrixUnitaire = item.PrixUnitaire;
        }

        public LigneFacture(DataRow row)
        {
            Id = Convert.ToInt32(row[nameof(Id)]);
            IdArticle = Convert.ToInt32(row[nameof(IdArticle)]);
            IdFacture = Convert.ToInt32(row[nameof(IdFacture)]); 
            Quantite = Convert.ToInt32(row[nameof(Quantite)]);
            PrixUnitaire = float.Parse(row[nameof(PrixUnitaire)].ToString());
        }
    }
}
