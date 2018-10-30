using ArticlesApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesApp.Models
{
    public class FactureLigne
    {
        public long Id { get; set; }
        public long ArticleId { get; set; }
        public long FactureId { get; set; } 
        public int Quantite { get; set; }
        public float PU { get; set; }

        public FactureLigne()
        {

        }

        public FactureLigne(FactureLigneViewModel item)
        {
            Id = item.Id;
            ArticleId = item.ArticleId;
            FactureId = item.FactureId;
            Quantite = item.Quantite;
            PU = item.PU;
        }

        public FactureLigne(DataRow row)
        {
            Id = Convert.ToInt32(row[nameof(Id)]);
            ArticleId = Convert.ToInt32(row[nameof(ArticleId)]);
            FactureId = Convert.ToInt32(row[nameof(FactureId)]); 
            Quantite = Convert.ToInt32(row[nameof(Quantite)]);
            PU = float.Parse(row[nameof(PU)].ToString());
        }
    }
}
