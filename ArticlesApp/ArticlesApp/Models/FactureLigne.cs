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
    public string Reference { get; set; }
    public string Designation { get; set; }
    public int Quantite { get; set; }
    public float PU { get; set; }

    public FactureLigne()
    {

    }

    public FactureLigne(DataRow row)
    {
      Id = Convert.ToInt32(row["Id"]);
      Reference = row["Reference"].ToString();
      Designation = row["Designation"].ToString();
      Quantite = Convert.ToInt32(row["Quantite"]);
      PU = float.Parse(row["PU"].ToString());
    }
  }
}
