using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesApp.Models
{
    public class Database
    {
        private readonly string ConnectionString;
        private SqlCommand Command;
        private SqlConnection Connection;

        public Database()
        {
            ConnectionString = @"Server=DESKTOP-4K8O21F\SQLEXPRESS;Database=ArticlesDB;Integrated Security=True;User Id=root;Password=root";
            Connection = new SqlConnection(ConnectionString);
        }

        private void Connect()
        {
            if (Connection == null)
                Connection = new SqlConnection(ConnectionString);
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
        }

        public DataTable Get(string query, List<SqlParameter> Parameters)
        {
            try
            {
                Connect();
                Command = new SqlCommand(query, Connection);
                if (Parameters != null && Parameters.Count > 0)
                    foreach (var param in Parameters)
                        Command.Parameters.Add(param);
                SqlDataAdapter adapter = new SqlDataAdapter(Command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Connection.Close();
                return null;
            }
        }

        public int Execute(string query, List<SqlParameter> Parameters, SqlTransaction transaction = null)
        {
            try
            {
                Connect();
                if (transaction != null)
                    Command = new SqlCommand(query, Connection,transaction);
                else
                    Command = new SqlCommand(query, Connection);

                if (Parameters != null && Parameters.Count > 0)
                    foreach (var param in Parameters)
                        Command.Parameters.Add(param);
                int result = Command.ExecuteNonQuery();
                Connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                Connection.Close();
                return -1;
            }
        }

        public object Scalar(string query, List<SqlParameter> Parameters)
        {
            try
            {
                Connect();
                Command = new SqlCommand(query, Connection);
                if (Parameters != null && Parameters.Count > 0)
                    foreach (var param in Parameters)
                        Command.Parameters.Add(param);
                object result = Command.ExecuteScalar();
                Connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                Connection.Close();
                return null;
            }
        }
    }
}
