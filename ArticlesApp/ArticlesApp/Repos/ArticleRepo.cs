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
      string query = "SELECT * FROM Articles ";
      List<Article> Articles = new List<Article>();
      DataTable dt = db.Get(query, null);
      if (dt != null && dt.Rows.Count > 0)
        foreach (DataRow row in dt.Rows)
          Articles.Add(new Article(row));
      return Articles;
    }

    public Article Get(long id)
    {
      string query = "SELECT * FROM Articles WHERE Id = @Id";
      List<SqlParameter> parameters = new List<SqlParameter>()
      {
          new SqlParameter("@Id",id)
      };
      DataTable dt = db.Get(query, parameters);
      if (dt != null && dt.Rows.Count > 0)
        return new Article(dt.Rows[0]);
      return null;
    }

    public void Insert(Article article)
    {
      string query = "INSERT INTO Articles(Ref,Description,Price,Quantity,IsInPromot,DateEndPromot) VALUES(@Ref,@Description,@Price,@Quantity,@IsInPromot,@DateEndPromot)";
      List<SqlParameter> parameters = new List<SqlParameter>()
      {
          new SqlParameter("Ref",article.Ref),
          new SqlParameter("Description",article.Description),
          new SqlParameter("Price",article.Price),
          new SqlParameter("Quantity",article.Quantity == null?(object)DBNull.Value:article.Quantity),
          new SqlParameter("IsInPromot",article.IsInPromot==null?(object)DBNull.Value:article.IsInPromot),
          new SqlParameter("DateEndPromot",article.DateEndPromot== null?(object)DBNull.Value:article.DateEndPromot),
      };
      db.Execute(query, parameters);
    }

    public void Edit(Article article)
    {
      string query = "UPDATE Articles SET Ref=@Ref,Description = @Description,Price = @Price,Quantity=@Quantity,IsInPromot = @IsInPromot,DateEndPromot=@DateEndPromot WHERE Id= @Id ";
      List<SqlParameter> parameters = new List<SqlParameter>()
      {
          new SqlParameter("Ref",article.Ref),
          new SqlParameter("Description",article.Description),
          new SqlParameter("Price",article.Price),
          new SqlParameter("Quantity",article.Quantity == null?(object)DBNull.Value:article.Quantity),
          new SqlParameter("IsInPromot",article.IsInPromot==null?(object)DBNull.Value:article.IsInPromot),
          new SqlParameter("DateEndPromot",article.DateEndPromot== null?(object)DBNull.Value:article.DateEndPromot),
          new SqlParameter("Id",article.Id)
      };
      db.Execute(query, parameters);
    }

    public void Remove(long id)
    {
      string query = "DELETE FROM Articles WHERE Id=@Id";
      List<SqlParameter> parameters = new List<SqlParameter>()
      {
          new SqlParameter("Id",id)
      };
      db.Execute(query, parameters);
    }
  }
}
