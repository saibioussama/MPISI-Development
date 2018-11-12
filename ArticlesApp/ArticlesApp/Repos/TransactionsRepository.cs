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
  public class TransactionsRepository
  {

    private readonly string ConnectionString;
    private SqlCommand Command;
    private SqlConnection Connection;
    private SqlTransaction transaction;

    public TransactionsRepository()
    {
      ConnectionString = Database.ConnectionString;
      Connection = new SqlConnection(ConnectionString);
    }

    public bool AddFactureUsingTransaction(Facture facture, List<FactureLigne> factureLignes, List<Article> articles)
    {

      try
      {
        #region Open connection & begin transaction 

        Connect();
        transaction = Connection.BeginTransaction();

        #endregion

        #region Insert facture 

        string query = $"INSERT INTO {nameof(Facture)} ({nameof(Facture.Reference)},{nameof(Facture.Date)},{nameof(Facture.Montant)}) VALUES(@{nameof(Facture.Reference)},@{nameof(Facture.Date)},@{nameof(Facture.Montant)})";
        List<SqlParameter> Parameters = new List<SqlParameter>()
      {
          new SqlParameter(nameof(Facture.Reference),facture.Reference),
          new SqlParameter(nameof(Facture.Date),facture.Date),
          new SqlParameter(nameof(Facture.Montant),facture.Montant),
      };

        Command = new SqlCommand(query, Connection, transaction);

        if (Parameters != null && Parameters.Count > 0)
        {
          foreach (var param in Parameters)
          {
            Command.Parameters.Add(param);
          }
        }

        int result = Command.ExecuteNonQuery();

        if (result == 0)
        {
          transaction.Rollback();
          return false;
        }

        #endregion

        #region Get inserted facture by reference

        query = $"SELECT * FROM {nameof(Facture)} WHERE {nameof(Facture.Reference)} = @{nameof(Facture.Reference)}";
        Parameters = new List<SqlParameter>()
      {
          new SqlParameter(nameof(Facture.Reference),facture.Reference)
      };

        Command = new SqlCommand(query, Connection, transaction);
        if (Parameters != null && Parameters.Count > 0)
          foreach (var param in Parameters)
            Command.Parameters.Add(param);
        SqlDataAdapter adapter = new SqlDataAdapter(Command);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        if (dt != null && dt.Rows.Count > 0)
          facture = new Facture(dt.Rows[0]);
        else
        {
          transaction.Rollback();
          return false;
        }

        #endregion

        #region Insert facture lignes 

        query = $"INSERT INTO {nameof(FactureLigne)}({nameof(FactureLigne.FactureId)},{nameof(FactureLigne.ArticleId)}, {nameof(FactureLigne.Quantite)},{nameof(FactureLigne.PU)}) VALUES(@{nameof(FactureLigne.FactureId)},@{nameof(FactureLigne.ArticleId)}, @{nameof(FactureLigne.Quantite)},@{nameof(FactureLigne.PU)})";
        foreach (FactureLigne factureLigne in factureLignes)
        {
          Parameters = new List<SqlParameter>()
        {
          new SqlParameter(nameof(FactureLigne.FactureId),facture.Id),
          new SqlParameter(nameof(FactureLigne.ArticleId),factureLigne.ArticleId),
          new SqlParameter(nameof(FactureLigne.Quantite),factureLigne.Quantite),
          new SqlParameter(nameof(FactureLigne.PU),factureLigne.PU),
          new SqlParameter(nameof(FactureLigne.Id),factureLigne.Id),
        };

          Command = new SqlCommand(query, Connection, transaction);

          if (Parameters != null && Parameters.Count > 0)
          {
            foreach (var param in Parameters)
            {
              Command.Parameters.Add(param);
            }
          }

          result = Command.ExecuteNonQuery();
          if (result == 0)
          {
            transaction.Rollback();
            return false;
          }
        }

        #endregion

        #region Update articles quantities

        query = $"UPDATE {nameof(Article)} SET " +
                  $"{nameof(Article.Quantite)} = {nameof(Article.Quantite)} - (@{nameof(Article.Quantite)}) " +
                  $"WHERE {nameof(Article.Id)}= @{nameof(Article.Id)}";
        foreach (Article article in articles)
        {
          Parameters = new List<SqlParameter>()
          {
              new SqlParameter(nameof(Article.Quantite),article.Quantite == null?(object)DBNull.Value:article.Quantite),
              new SqlParameter(nameof(Article.Id),article.Id)
          };

          Command = new SqlCommand(query, Connection, transaction);

          if (Parameters != null && Parameters.Count > 0)
          {
            foreach (var param in Parameters)
            {
              Command.Parameters.Add(param);
            }
          }

          result = Command.ExecuteNonQuery();
          if (result == 0)
          {
            transaction.Rollback();
            return false;
          }
        }

        #endregion

        #region Commit changes 

        transaction.Commit();
        Connection.Close();

        #endregion

        return true;
      }
      catch (Exception)
      {
        transaction.Rollback();
        Connection.Close();

        return false;
      }

    }

    private void Connect()
    {
      if (Connection == null)
        Connection = new SqlConnection(ConnectionString);
      if (Connection.State != ConnectionState.Open)
        Connection.Open();
    }
  }
}
