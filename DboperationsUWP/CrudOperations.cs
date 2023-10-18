using System;
using System.Data.SqlClient;
using System.Data;




namespace DboperationsUWP
{
    public class CrudOperations
    {
        SqlConnection _connection;
        string _connectionString;
        public CrudOperations()
        {
            _connectionString = "Data Source=NARESHSUNKARI;user ID=sa;Password=123456789;Initial Catalog=Demo";
            _connection = new SqlConnection(_connectionString);

        }

        public int CreateRecord(string name, string designation)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "insert into example values('" + name + "','" + designation + "')";
            sqlCommand.Connection = _connection;
            _connection.Open();
            var result = sqlCommand.ExecuteNonQuery();
            _connection.Close();
            return result;

        }
    }
}
