﻿using ArticlesApp.Models;
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

        public int Insert(Facture facture)
        {
            string query = "INSERT INTO Facture (Reference,Date,Montant) VALUES(@Reference,@Date,@Montant)";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                  new SqlParameter(nameof(facture.Reference),facture.Reference),
                  new SqlParameter(nameof(facture.Date),facture.Date),
                  new SqlParameter(nameof(facture.Montant),facture.Montant),
              };
            return db.Execute(query, parameters);
        }

        public int Edit(Facture facture)
        {
            string query = "UPDATE Facture SET Reference =@Reference , Date=@Date,Montant = @Montant WHERE Id= @Id ";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                  new SqlParameter(nameof(facture.Reference),facture.Reference),
                  new SqlParameter(nameof(facture.Date),facture.Date),
                  new SqlParameter(nameof(facture.Montant),facture.Montant),
                  new SqlParameter(nameof(facture.Id),facture.Id)
              };
            return db.Execute(query, parameters);
        }

        public int Remove(long id)
        {
            string query = "DELETE FROM Facture WHERE Id=@Id";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                  new SqlParameter("Id",id)
              };
            return db.Execute(query, parameters);
        }

        public int GetLastInsertedId()
        {
            string query = "SELECT TOP(1) * FROM Facture ORDER BY Id DESC";
            DataTable dt = db.Get(query, null);
            if (dt != null && dt.Rows.Count > 0)
                return (int)dt.Rows[0]["Id"];

            return -1;
        }

        public bool IsExist(string Reference)
        {
            string query = "SELECT TOP(1) * FROM Facture WHERE Reference = @Reference";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter(nameof(Reference),Reference),
            };
            DataTable dt = db.Get(query, parameters);
            return dt != null && dt.Rows.Count > 0;
        }

    }
}