using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Repos
{
    public class ObjectRepo
    {
        public static DataTable Get(string DBName,string DTName)
        {
            try
            {
                string connectionstring = @"Server=DESKTOP-4K8O21F\SQLEXPRESS;Database=" + DBName + ";Integrated Security=True;User Id=root;Password=root";
                SqlConnection connexion = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand($"SELECT * FROM {DTName}", connexion);
                if (connexion.State != ConnectionState.Open)
                    connexion.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                return dt;
            }
            catch
            {
                return new DataTable();
            }
        }
    }
}
