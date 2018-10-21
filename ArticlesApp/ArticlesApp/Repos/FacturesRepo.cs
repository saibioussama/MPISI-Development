using ArticlesApp.Models;
using ArticlesApp.Repos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturesApp.Repos
{
  public class FacturesRepo : IRepository<Facture, long>
  {
    private Database db;

    public FacturesRepo()
    {
      db = new Database();
    }

    public List<Facture> Get()
    {
      string query = "SELECT * FROM Facture";
      List<Facture> Factures = new List<Facture>();
      DataTable dt = db.Get(query, null);
      if (dt != null && dt.Rows.Count > 0)
        foreach (DataRow row in dt.Rows)
          Factures.Add(new Facture(row));
      return Factures;
    }

    public Facture Get(long id)
    {
      string query = "SELECT * FROM Facture  WHERE Id = @Id";
      List<SqlParameter> parameters = new List<SqlParameter>()
      {
          new SqlParameter("@Id",id)
      };
      DataTable dt = db.Get(query, parameters);
      if (dt != null && dt.Rows.Count > 0)
        return new Facture(dt.Rows[0]);
      return null;
    }

    public void Insert(Facture article)
    {
      string query = "INSERT INTO Facture (Reference,Date,Montant) VALUES(@Reference,@Date,@Montant)";
      List<SqlParameter> parameters = new List<SqlParameter>()
      {
          new SqlParameter(nameof(article.Reference),article.Reference),
          new SqlParameter(nameof(article.Date),article.Date),
          new SqlParameter(nameof(article.Montant),article.Montant),
      };
      db.Execute(query, parameters);
    }

    public void Edit(Facture article)
    {
      string query = "UPDATE Facture SET Reference =@Reference , Date=@Date,Montant = @Montant WHERE Id= @Id ";
      List<SqlParameter> parameters = new List<SqlParameter>()
      {
          new SqlParameter(nameof(article.Reference),article.Reference),
          new SqlParameter(nameof(article.Date),article.Date),
          new SqlParameter(nameof(article.Montant),article.Montant),
      };
      db.Execute(query, parameters);
    }

    public void Remove(long id)
    {
      string query = "DELETE FROM Facture WHERE Id=@Id";
      List<SqlParameter> parameters = new List<SqlParameter>()
      {
          new SqlParameter("Id",id)
      };
      db.Execute(query, parameters);
    }
  }
}
