using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesApp.Models
{
  public class Article
  {
    public int Id { get; set; }
    public string Reference { get; set; }
    public string Designation { get; set; }
    public float Prix { get; set; }
    public int? Quantite { get; set; }
    public bool? Promo { get; set; }
    public DateTime? DateFinPromo { get; set; }

    public Article()
    {

    }

    public Article(DataRow row)
    {
      Id = Convert.ToInt32(row[nameof(Id)]);
      Reference = row[nameof(Reference)].ToString();
      Designation = row[nameof(Designation)].ToString();
      Prix = float.Parse(row[nameof(Prix)].ToString());
      if (!Convert.IsDBNull(row[nameof(Quantite)]))
        Quantite = Convert.ToInt32(row[nameof(Quantite)]);
      else
        Quantite = null;
      if (!Convert.IsDBNull(row[nameof(Promo)]))
        Promo = Convert.ToBoolean(row[nameof(Promo)]);
      else
        Promo = null;
      if (!Convert.IsDBNull(row[nameof(DateFinPromo)]))
        DateFinPromo = Convert.ToDateTime(row[nameof(DateFinPromo)]);
      else
        DateFinPromo = null;


    }
  }
}
