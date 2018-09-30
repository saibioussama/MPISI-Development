using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1CL.Models
{
    public class Article
    {
        public string Ref { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Article()
        {

        }

        public Article(DataRow dr)
        {
            Ref = dr["Ref"].ToString();
            Description = dr["Description"].ToString();
            Price = Convert.ToDecimal(dr["Price"]);
        }
    }
}
