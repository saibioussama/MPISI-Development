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
    public class FactureLigneRepo : IRepository<LigneFacture, int>
    {

        private readonly Database db;

        public FactureLigneRepo()
        {
            db = new Database();
        }

        public int Edit(LigneFacture factureLigne)
        {
            string query = $"UPDATE {nameof(LigneFacture)} SET {nameof(LigneFacture.IdArticle)} = @{nameof(LigneFacture.IdArticle)}," +
                $" {nameof(LigneFacture.IdFacture)} = @{nameof(LigneFacture.IdFacture)} ," +
                $" {nameof(LigneFacture.Quantite)} = @{nameof(LigneFacture.Quantite)}," +
                $"{nameof(LigneFacture.PrixUnitaire)} = @{nameof(LigneFacture.PrixUnitaire)} " +
                $"WHERE {nameof(LigneFacture.Id)} = @{nameof(LigneFacture.Id)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                new SqlParameter(nameof(LigneFacture.IdArticle),factureLigne.IdArticle),
                new SqlParameter(nameof(LigneFacture.IdFacture),factureLigne.IdFacture),
                new SqlParameter(nameof(LigneFacture.Quantite),factureLigne.Quantite),
                new SqlParameter(nameof(LigneFacture.PrixUnitaire),factureLigne.PrixUnitaire),
                new SqlParameter(nameof(LigneFacture.Id),factureLigne.Id),
              };

            return db.Execute(query, parameters);
        }

        public List<LigneFacture> Get()
        {
            string query = $"SELECT * FROM {nameof(LigneFacture)}";
            DataTable dt = db.Get(query, null);
            List<LigneFacture> factureLignes = new List<LigneFacture>();
            if (dt != null && dt.Rows.Count > 0)
                foreach (DataRow row in dt.Rows)
                    factureLignes.Add(new LigneFacture(row));
            return factureLignes;
        }

        public LigneFacture Get(int id)
        {
            string query = $"SELECT * FROM {nameof(LigneFacture)} WHERE {nameof(LigneFacture.Id)} = @{nameof(LigneFacture.Id)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
      {
        new SqlParameter(nameof(LigneFacture.Id),id)
      };
            DataTable dt = db.Get(query, parameters);
            if (dt != null && dt.Rows.Count > 0)
                return new LigneFacture(dt.Rows[0]);
            return null;
        }

        public int Insert(LigneFacture factureLigne)
        {
            string query = $"INSERT INTO {nameof(LigneFacture)}({nameof(LigneFacture.IdFacture)},{nameof(LigneFacture.IdArticle)}, {nameof(LigneFacture.Quantite)},{nameof(LigneFacture.PrixUnitaire)}) VALUES(@{nameof(LigneFacture.IdFacture)},@{nameof(LigneFacture.IdArticle)}, @{nameof(LigneFacture.Quantite)},@{nameof(LigneFacture.PrixUnitaire)})";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                new SqlParameter(nameof(LigneFacture.IdFacture),factureLigne.IdFacture),
                new SqlParameter(nameof(LigneFacture.IdArticle),factureLigne.IdArticle),
                new SqlParameter(nameof(LigneFacture.Quantite),factureLigne.Quantite),
                new SqlParameter(nameof(LigneFacture.PrixUnitaire),factureLigne.PrixUnitaire),
                new SqlParameter(nameof(LigneFacture.Id),factureLigne.Id),
              };

            return db.Execute(query, parameters);
        }

        public int Remove(int id)
        {
            string query = $"DELETE FROM {nameof(LigneFacture)} WHERE {nameof(LigneFacture.Id)} = @{nameof(LigneFacture.Id)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                new SqlParameter(nameof(LigneFacture.Id),id)
              };

            return db.Execute(query, parameters);
        }


        public List<LigneFacture> GetByFactureId(int IdFacture)
        {
            string query = $"SELECT * FROM {nameof(LigneFacture)} WHERE {nameof(LigneFacture.IdFacture)} =@{nameof(LigneFacture.IdFacture)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter(nameof(LigneFacture.IdFacture),IdFacture)
            };
            DataTable dt = db.Get(query, parameters);
            List<LigneFacture> factureLignes = new List<LigneFacture>();
            if (dt != null && dt.Rows.Count > 0)
                foreach (DataRow row in dt.Rows)
                    factureLignes.Add(new LigneFacture(row));
            return factureLignes;
        }
    }
}
