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
    public class ArticleRepo : IRepository<Article, long>
    {
        private Database db;
        public ArticleRepo()
        {
            db = new Database();
        }

        public List<Article> Get()
        {
            string query = $"SELECT * FROM {nameof(Article)} ";
            List<Article> Articles = new List<Article>();
            DataTable dt = db.Get(query, null);
            if (dt != null && dt.Rows.Count > 0)
                foreach (DataRow row in dt.Rows)
                    Articles.Add(new Article(row));
            return Articles;
        }

        public Article Get(long id)
        {
            string query = $"SELECT * FROM {nameof(Article)} WHERE {nameof(Article.Id)} = @{nameof(Article.Id)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                  new SqlParameter($"@{nameof(Article.Id)}",id)
              };
            DataTable dt = db.Get(query, parameters);
            if (dt != null && dt.Rows.Count > 0)
                return new Article(dt.Rows[0]);
            return null;
        }

        public Article Get(string Reference)
        {
            string query = $"SELECT * FROM {nameof(Article)} WHERE {nameof(Article.Reference)} = @{nameof(Article.Reference)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                  new SqlParameter(nameof(Article.Reference),Reference),
              };
            DataTable dt = db.Get(query, parameters);
            if (dt != null && dt.Rows.Count > 0)
                return new Article(dt.Rows[0]);
            return null;
        }

        public int Insert(Article article)
        {
            string query = $"INSERT INTO {nameof(Article)}({nameof(Article.Reference)},{nameof(Article.Designation)},{nameof(Article.Prix)},{nameof(Article.Quantite)},{nameof(Article.Promo)},{nameof(Article.DateFinPromo)}) VALUES(@{nameof(Article.Reference)},@{nameof(Article.Designation)},@{nameof(Article.Prix)},@{nameof(Article.Quantite)},@{nameof(Article.Promo)},@{nameof(Article.DateFinPromo)})";
            List<SqlParameter> parameters = new List<SqlParameter>()
      {
          new SqlParameter(nameof(Article.Reference),article.Reference),
          new SqlParameter(nameof(Article.Designation),article.Designation),
          new SqlParameter(nameof(Article.Prix),article.Prix),
          new SqlParameter(nameof(Article.Quantite),article.Quantite == null?(object)DBNull.Value:article.Quantite),
          new SqlParameter(nameof(Article.Promo),article.Promo==null?(object)DBNull.Value:article.Promo),
          new SqlParameter(nameof(Article.DateFinPromo),article.DateFinPromo== null?(object)DBNull.Value:article.DateFinPromo),
      };
            return db.Execute(query, parameters);
        }

        public int Edit(Article article)
        {
            string query = $"UPDATE {nameof(Article)} SET {nameof(Article.Reference)}=@{nameof(Article.Reference)}," +
                $"{nameof(Article.Designation)}= @{nameof(Article.Designation)}," +
                $"{nameof(Article.Prix)}= @{nameof(Article.Prix)}," +
                $"{nameof(Article.Quantite)}=@{nameof(Article.Quantite)}," +
                $"{nameof(Article.Promo)}= @{nameof(Article.Promo)}," +
                $"{nameof(Article.DateFinPromo)}=@{nameof(Article.DateFinPromo)} " +
                $"WHERE {nameof(Article.Id)}= @{nameof(Article.Id)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
      {
          new SqlParameter(nameof(Article.Reference),article.Reference),
          new SqlParameter(nameof(Article.Designation),article.Designation),
          new SqlParameter(nameof(Article.Prix),article.Prix),
          new SqlParameter(nameof(Article.Quantite),article.Quantite == null?(object)DBNull.Value:article.Quantite),
          new SqlParameter(nameof(Article.Promo),article.Promo==null?(object)DBNull.Value:article.Promo),
          new SqlParameter(nameof(Article.DateFinPromo),article.DateFinPromo== null?(object)DBNull.Value:article.DateFinPromo),
          new SqlParameter(nameof(Article.Id),article.Id)
      };
            return db.Execute(query, parameters);
        }

        public int Remove(long id)
        {
            string query = $"DELETE FROM {nameof(Article)} WHERE {nameof(Article.Id)}=@{nameof(Article.Id)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
              {
                  new SqlParameter(nameof(Article.Id),id)
              };
            return db.Execute(query, parameters);
        }

        public bool IsExist(string Reference)
        {
            string query = $"SELECT TOP(1) * FROM {nameof(Article)} WHERE {nameof(Article.Reference)} = @{nameof(Article.Reference)}";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter(nameof(Article.Reference),Reference),
            };
            DataTable dt = db.Get(query, parameters);
            return dt != null && dt.Rows.Count > 0;
        }
    }
}
