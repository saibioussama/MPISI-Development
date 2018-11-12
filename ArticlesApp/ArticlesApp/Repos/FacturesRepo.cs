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
            string query = $"SELECT * FROM {nameof(Facture)}";
            List<Facture> Factures = new List<Facture>();
            DataTable dt = db.Get(query, null);
            if (dt != null && dt.Rows.Count > 0)
                foreach (DataRow row in dt.Rows)
                    Factures.Add(new Facture(row));
            return Factures;
        }

        public Facture Get(long id)
        {
            string query = $"SELECT * FROM {nameof(Facture)} WHERE {nameof(Facture.Id)} = @{nameof(Facture.Id)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                  new SqlParameter(nameof(Facture.Id),id)
              };
            DataTable dt = db.Get(query, parameters);
            if (dt != null && dt.Rows.Count > 0)
                return new Facture(dt.Rows[0]);
            return null;
        }

        public int Insert(Facture facture)
        {
            string query = $"INSERT INTO {nameof(Facture)} ({nameof(Facture.Reference)},{nameof(Facture.Date)},{nameof(Facture.Montant)}) VALUES(@{nameof(Facture.Reference)},@{nameof(Facture.Date)},@{nameof(Facture.Montant)})";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                  new SqlParameter(nameof(Facture.Reference),facture.Reference),
                  new SqlParameter(nameof(Facture.Date),facture.Date),
                  new SqlParameter(nameof(Facture.Montant),facture.Montant),
              };
            return db.Execute(query, parameters);
        }

        public int Edit(Facture facture)
        {
            string query = $"UPDATE {nameof(Facture)} SET {nameof(Facture.Reference)} = @{nameof(Facture.Reference)}," +
                $" {nameof(Facture.Date)}=@{nameof(Facture.Date)}," +
                $"{nameof(Facture.Montant)} = @{nameof(Facture.Montant)} " +
                $"WHERE {nameof(Facture.Id)}= @{nameof(Facture.Id)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                  new SqlParameter(nameof(Facture.Reference),facture.Reference),
                  new SqlParameter(nameof(Facture.Date),facture.Date),
                  new SqlParameter(nameof(Facture.Montant),facture.Montant),
                  new SqlParameter(nameof(Facture.Id),facture.Id)
              };
            return db.Execute(query, parameters);
        }

        public int Remove(long id)
        {
            string query = $"DELETE FROM {nameof(Facture)} WHERE {nameof(Facture.Id)}=@{nameof(Facture.Id)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                  new SqlParameter(nameof(Facture.Id),id)
              };
            return db.Execute(query, parameters);
        }

        public int GetLastInsertedId()
        {
            string query = $"SELECT TOP(1) * FROM {nameof(Facture)} ORDER BY {nameof(Facture.Id)} DESC";
            DataTable dt = db.Get(query, null);
            if (dt != null && dt.Rows.Count > 0)
                return (int)dt.Rows[0][nameof(Facture.Id)];

            return -1;
        }

        public int GetIdByReference(string Reference)
        {
            string query = $"SELECT TOP(1) * FROM {nameof(Facture)} WHERE {nameof(Facture.Reference)} = @{nameof(Facture.Reference)} ORDER BY {nameof(Facture.Id)} DESC";
            DataTable dt = db.Get(query, null);
            if (dt != null && dt.Rows.Count > 0)
                return (int)dt.Rows[0][nameof(Facture.Id)];

            return -1;
        }

        public bool IsExist(string Reference)
        {
            string query = $"SELECT TOP(1) * FROM {nameof(Facture)} WHERE {nameof(Facture.Reference)} = @{nameof(Facture.Reference)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter(nameof(Facture.Reference),Reference),
            };
            DataTable dt = db.Get(query, parameters);
            return dt != null && dt.Rows.Count > 0;
        }

        
    }
}
