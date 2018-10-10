using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesApp.Models
{
    public class Article
    {
        public long Id { get; set; }
        public string Ref { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int? Quantity { get; set; }
        public bool? IsInPromot { get; set; }
        public DateTime? DateEndPromot { get; set; }

        public Article()
        {

        }

        public Article(DataRow row)
        {
            Id = Convert.ToInt64(row["Id"]);
            Ref = row["Ref"].ToString();
            Description = row["Description"].ToString();
            Price = Convert.ToDouble(row["Price"]);
            if (!Convert.IsDBNull(row["Quantity"]))
                Quantity = Convert.ToInt32(row["Quantity"]);
            else
                Quantity = null;
            if (!Convert.IsDBNull(row["IsInPromot"]))
                IsInPromot = Convert.ToBoolean(row["IsInPromot"]);
            else
                IsInPromot = null;
            if (!Convert.IsDBNull(row["DateEndPromot"]))
                DateEndPromot = Convert.ToDateTime(row["DateEndPromot"]);
            else
                DateEndPromot = null;
            

        }
    }
}
