using App1CL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1CL.Repositories
{
    public class ArticlesRepo : IRepository<Article>
    {
        private Database db = new Database();

        public int Count()
        {
            string query = "SELECT COUNT(*) FROM Articles";
            return (int)db.Scalar(query, null);
        }

        public void Edit(Article article)
        {
            string query = "UPDATE Articles SET Description =@Description ,Price=@Price WHERE Ref = @Ref";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("Description",article.Description),
                new SqlParameter("Ref",article.Ref),
                new SqlParameter("Price",article.Price)
            };
            db.Execute(query, parameters);
        }

        public Article Get(string Ref)
        {
            string query = "SELECT * FROM Articles WHERE Ref=@Ref";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("Ref",Ref)
            };
            DataTable dt = db.Get(query, parameters);
            if (dt != null && dt.Rows.Count > 0)
                return new Article(dt.Rows[0]);
            return null;
        }

        public List<Article> Get()
        {
            string query = "SELECT * FROM Articles";
            List<Article> articles = new List<Article>();
            DataTable dt = db.Get(query, null);
            if (dt != null && dt.Rows.Count > 0)
                foreach (DataRow row in dt.Rows)
                    articles.Add(new Article(row));
            return articles;
        }

        public void Insert(Article article)
        {
            string query = "INSERT INTO Articles(Ref,Description ,Price) VALUES(@Ref,@Description ,@Price)";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("Ref",article.Ref),
                new SqlParameter("Description",article.Description),
                new SqlParameter("Price",article.Price)
            };
            db.Execute(query, parameters);
        }

        public void Remove(string Ref)
        {
            string query = "DELETE FROM Articles WHERE Ref = @Ref";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("Ref",Ref)
            };
            db.Execute(query, parameters);
        }
    }
}
