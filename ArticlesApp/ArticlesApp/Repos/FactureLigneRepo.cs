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

        public int Edit(FactureLigne factureLigne)
        {
            string query = $"UPDATE {nameof(FactureLigne)} SET {nameof(FactureLigne.ArticleId)} = @{nameof(FactureLigne.ArticleId)}," +
                $" {nameof(FactureLigne.FactureId)} = @{nameof(FactureLigne.FactureId)} ," +
                $" {nameof(FactureLigne.Quantite)} = @{nameof(FactureLigne.Quantite)}," +
                $"{nameof(FactureLigne.PU)} = @{nameof(FactureLigne.PU)} " +
                $"WHERE {nameof(FactureLigne.Id)} = @{nameof(FactureLigne.Id)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                new SqlParameter(nameof(FactureLigne.ArticleId),factureLigne.ArticleId),
                new SqlParameter(nameof(FactureLigne.FactureId),factureLigne.FactureId),
                new SqlParameter(nameof(FactureLigne.Quantite),factureLigne.Quantite),
                new SqlParameter(nameof(FactureLigne.PU),factureLigne.PU),
                new SqlParameter(nameof(FactureLigne.Id),factureLigne.Id),
              };

            return db.Execute(query, parameters);
        }

        public List<FactureLigne> Get()
        {
            string query = $"SELECT * FROM {nameof(FactureLigne)}";
            DataTable dt = db.Get(query, null);
            List<FactureLigne> factureLignes = new List<FactureLigne>();
            if (dt != null && dt.Rows.Count > 0)
                foreach (DataRow row in dt.Rows)
                    factureLignes.Add(new FactureLigne(row));
            return factureLignes;
        }

        public FactureLigne Get(long id)
        {
            string query = $"SELECT * FROM {nameof(FactureLigne)} WHERE {nameof(FactureLigne.Id)} = @{nameof(FactureLigne.Id)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
      {
        new SqlParameter(nameof(FactureLigne.Id),id)
      };
            DataTable dt = db.Get(query, parameters);
            if (dt != null && dt.Rows.Count > 0)
                return new FactureLigne(dt.Rows[0]);
            return null;
        }

        public int Insert(FactureLigne factureLigne)
        {
            string query = $"INSERT INTO {nameof(FactureLigne)}({nameof(FactureLigne.FactureId)},{nameof(FactureLigne.ArticleId)}, {nameof(FactureLigne.Quantite)},{nameof(FactureLigne.PU)}) VALUES(@{nameof(FactureLigne.FactureId)},@{nameof(FactureLigne.ArticleId)}, @{nameof(FactureLigne.Quantite)},@{nameof(FactureLigne.PU)})";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                new SqlParameter(nameof(FactureLigne.FactureId),factureLigne.FactureId),
                new SqlParameter(nameof(FactureLigne.ArticleId),factureLigne.ArticleId),
                new SqlParameter(nameof(FactureLigne.Quantite),factureLigne.Quantite),
                new SqlParameter(nameof(FactureLigne.PU),factureLigne.PU),
                new SqlParameter(nameof(FactureLigne.Id),factureLigne.Id),
              };

            return db.Execute(query, parameters);
        }

        public int Remove(long id)
        {
            string query = $"DELETE FROM {nameof(FactureLigne)} WHERE {nameof(FactureLigne.Id)} = @{nameof(FactureLigne.Id)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                new SqlParameter(nameof(FactureLigne.Id),id)
              };

            return db.Execute(query, parameters);
        }


        public List<FactureLigne> GetByFactureId(long FactureId)
        {
            string query = $"SELECT * FROM {nameof(FactureLigne)} WHERE {nameof(FactureLigne.FactureId)} =@{nameof(FactureLigne.FactureId)}";
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
