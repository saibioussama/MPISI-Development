using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1CL.Repositories
{
    class Database
    {
        private readonly string ConnectionString;
        private SqlConnection Connection;
        private SqlCommand Command;

        public Database()
        {
            ConnectionString = @"Server=DESKTOP-4K8O21F\SQLEXPRESS;Database=app1;Integrated Security=True; ";
        }

        private void Connect()
        {
            if (Connection == null)
                Connection = new SqlConnection(ConnectionString);

            if (Connection.State != System.Data.ConnectionState.Open)
                Connection.Open();
        }

        public int Execute(string query, List<SqlParameter> parameters)
        {
            Connect();

            Command = new SqlCommand(query, Connection);

            if (Command != null)
                foreach (var parameter in parameters)
                    Command.Parameters.Add(parameter);

            int result = Command.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public DataTable Get(string query, List<SqlParameter> parameters)
        {
            Connect();

            Command = new SqlCommand(query, Connection);

            if (parameters != null)
                foreach (var parameter in parameters)
                    Command.Parameters.Add(parameter);

            SqlDataAdapter adapter = new SqlDataAdapter(Command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            Connection.Close();

            return dataTable;
        }

        public object Scalar(string query, List<SqlParameter> parameters)
        {
            Connect();

            Command = new SqlCommand(query, Connection);

            if (parameters != null)
                foreach (var parameter in parameters)
                    Command.Parameters.Add(parameter);

            object result = Command.ExecuteScalar();

            Connection.Close();

            return result;
        }
    }
}
