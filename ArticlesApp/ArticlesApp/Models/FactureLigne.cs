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
        public string Reference { get; set; }
        public string Designation { get; set; }
        public int Quantite { get; set; }
        public float PU { get; set; }

        public FactureLigne()
        {

        }

        public FactureLigne(DataRow row)
        {
            Id = Convert.ToInt32(row[nameof(Id)]);
            ArticleId = Convert.ToInt32(row[nameof(ArticleId)]);
            ArticleId = Convert.ToInt32(row[nameof(FactureId)]);
            Reference = row[nameof(Reference)].ToString();
            Designation = row[nameof(Designation)].ToString();
            Quantite = Convert.ToInt32(row[nameof(Quantite)]);
            PU = float.Parse(row[nameof(PU)].ToString());
        }
    }
}
