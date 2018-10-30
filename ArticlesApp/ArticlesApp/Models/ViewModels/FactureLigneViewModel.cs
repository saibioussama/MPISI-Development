using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesApp.Models.ViewModels
{
    public class FactureLigneViewModel
    {
        public long Id { get; set; }
        public long ArticleId { get; set; }
        public long FactureId { get; set; }
        public string Reference { get; set; }
        public string Designation { get; set; }
        public int Quantite { get; set; }
        public float PU { get; set; }

        public FactureLigneViewModel()
        {

        }

        public FactureLigneViewModel(FactureLigne factureLigne,Article article)
        {
            ArticleId = factureLigne.Id;
            FactureId = factureLigne.FactureId;
            Reference = article.Reference;
            Designation = article.Designation;
            PU = article.Prix;
            Quantite = factureLigne.Quantite;
        }

        public FactureLigneViewModel(FactureLigne factureLigne)
        {
            ArticleId = factureLigne.ArticleId;
            FactureId = factureLigne.FactureId;
        }

        public FactureLigneViewModel(Article article)
        {
            ArticleId = article.Id;
            Reference = article.Reference;
            Designation = article.Designation;
            PU = article.Prix;
        }

    }

}
