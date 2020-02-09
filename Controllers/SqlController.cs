using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

namespace api.ejercicio.Controllers
{
    public class SqlController : ControllerBase
    {
        private string ConnectionString = "el connection string";
        private SqlConnection conn;

        public SqlController()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
        }

        ~SqlController()
        {
            conn.Close();
        }

        protected SqlDataReader GetReader(string sql)
        {
            var command = new SqlCommand(sql, conn);
            return command.ExecuteReader();
        }


    }
}