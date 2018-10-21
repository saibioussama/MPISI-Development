using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesApp.Models
{
  public class Facture
  {
    public int Id { get; set; }
    public string Reference { get; set; }
    public DateTime Date { get; set; }
    public float Montant { get; set; }

    public Facture()
    {

    }

    public Facture(DataRow row)
    {
      Id = Convert.ToInt32(row["Id"]);
      Reference = row["Reference"].ToString();
      Date = Convert.ToDateTime(row["Date"]);
      Montant = float.Parse(row["Montant"].ToString());
    }
  }
}
