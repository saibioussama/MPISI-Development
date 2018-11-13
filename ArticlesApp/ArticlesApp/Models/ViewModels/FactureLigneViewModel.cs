using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesApp.Models.ViewModels
{
  public class FactureLigneViewModel
  {

    public int Id { get; set; }
    public int IdArticle { get; set; }
    public int IdFacture { get; set; }
    public string Reference { get; set; }
    public string Designation { get; set; }
    public int Quantite { get; set; }
    public float PrixUnitaire { get; set; }
    public float Total { get; set; }

    #region Constactors

    public FactureLigneViewModel() { }

    public FactureLigneViewModel(LigneFacture factureLigne)
    {
      IdArticle = factureLigne.IdArticle;
      IdFacture = factureLigne.IdFacture;
      Quantite = factureLigne.Quantite;
      PrixUnitaire = factureLigne.PrixUnitaire;
      Total = factureLigne.Quantite * factureLigne.PrixUnitaire;
    }

    public FactureLigneViewModel(LigneFacture factureLigne, Article article)
    {
      IdArticle = factureLigne.Id;
      IdFacture = factureLigne.IdFacture;
      Reference = article.Reference;
      Designation = article.Designation;
      PrixUnitaire = article.Prix;
      Quantite = factureLigne.Quantite;
      Total = factureLigne.Quantite * factureLigne.PrixUnitaire;
    }

    public FactureLigneViewModel(Article article)
    {
      IdArticle = article.Id;
      Reference = article.Reference;
      Designation = article.Designation;
      PrixUnitaire = article.Prix;
    }

    #endregion

  }

}
