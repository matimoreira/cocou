using System.Collections.Generic;
using System.Data.SqlClient;
using api.ejercicio.models;
using Microsoft.AspNetCore.Mvc;

namespace api.ejercicio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriverController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Driver> Get()
        {
            var resultado = new List<Driver>();

            var connectionString = "alguna connection string";
            var connection = new SqlConnection(connectionString);
            connection.Open();

            var sql = "SELECT id, firstname, lastname, phone, email FROM driver";
            var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                resultado.Add(
                    new Driver
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Phone = reader.GetString(3),
                        Email = reader.GetString(4)
                    }
                );
            }

            reader.Close();
            connection.Close();
            
            return resultado;
        }


    }


}