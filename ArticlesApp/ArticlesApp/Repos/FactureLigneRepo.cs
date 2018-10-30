using ArticlesApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesApp.Repos
{
    public class FactureLigneRepo : IRepository<FactureLigne, long>
    {

        private readonly Database db;
        
        public FactureLigneRepo()
        {
            db = new Database();
        }

        public int Edit(FactureLigne article)
        {
            string query = "UPDATE FactureLigne SET ArticleId = @ArticleId , FactureId = @FactureId , Reference = @Reference , Designation = @Designation, Quantite = @Quantite , PU = @PU WHERE Id = @Id ";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                new SqlParameter(nameof(article.ArticleId),article.ArticleId),
                new SqlParameter(nameof(article.FactureId),article.FactureId),
                new SqlParameter(nameof(article.Reference),article.Reference),
                new SqlParameter(nameof(article.Designation),article.Designation),
                new SqlParameter(nameof(article.Quantite),article.Quantite),
                new SqlParameter(nameof(article.PU),article.PU),
                new SqlParameter(nameof(article.Id),article.Id),
              };
           
                return db.Execute(query, parameters);
        }

        public List<FactureLigne> Get()
        {
            string query = "SELECT * FROM FactureLigne";
            DataTable dt = db.Get(query, null);
            List<FactureLigne> factureLignes = new List<FactureLigne>();
            if (dt != null && dt.Rows.Count > 0)
                foreach (DataRow row in dt.Rows)
                    factureLignes.Add(new FactureLigne(row));
            return factureLignes;
        }

        public FactureLigne Get(long id)
        {
            string query = "SELECT * FROM FactureLigne WHERE Id = @Id";
            List<SqlParameter> parameters = new List<SqlParameter>()
      {
        new SqlParameter("Id",id)
      };
            DataTable dt = db.Get(query, parameters);
            if (dt != null && dt.Rows.Count > 0)
                return new FactureLigne(dt.Rows[0]);
            return null;
        }

        public int Insert(FactureLigne article)
        {
            string query = "INSERT INTO FactureLigne(FactureId,ArticleId,Reference,Designation, Quantite,PU) VALUES(@FactureId,@ArticleId,@Reference,@Designation, @Quantite,@PU)";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                new SqlParameter(nameof(article.FactureId),article.FactureId),
                new SqlParameter(nameof(article.ArticleId),article.ArticleId),
                new SqlParameter(nameof(article.Reference),article.Reference),
                new SqlParameter(nameof(article.Designation),article.Designation),
                new SqlParameter(nameof(article.Quantite),article.Quantite),
                new SqlParameter(nameof(article.PU),article.PU),
                new SqlParameter(nameof(article.Id),article.Id),
              };
            
                return db.Execute(query, parameters);
        }

        public int Remove(long id)
        {
            string query = "DELETE FROM FactureLigne WHERE Id = @Id";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                new SqlParameter("Id",id)
              };
           
                return db.Execute(query, parameters);
        }


        public List<FactureLigne> GetByFactureId(long FactureId)
        {
            string query = "SELECT * FROM FactureLigne WHERE FactureId =@FactureId";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter(nameof(FactureId),FactureId)
            };
            DataTable dt = db.Get(query, parameters);
            List<FactureLigne> factureLignes = new List<FactureLigne>();
            if (dt != null && dt.Rows.Count > 0)
                foreach (DataRow row in dt.Rows)
                    factureLignes.Add(new FactureLigne(row));
            return factureLignes;
        }
    }
}
