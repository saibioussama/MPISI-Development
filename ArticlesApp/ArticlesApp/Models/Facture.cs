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
    public float Total { get; set; } = 0;





    public Facture()
    {

    }

    public Facture(DataRow row)
    {
      Id = Convert.ToInt32(row[nameof(Facture.Id)]);
      Reference = row[nameof(Facture.Reference)].ToString();
      Date = Convert.ToDateTime(row[nameof(Facture.Date)]);
      if (!Convert.IsDBNull(row[nameof(Total)]))
        Total = float.Parse(row[nameof(Facture.Total)].ToString());
    }
  }
}
