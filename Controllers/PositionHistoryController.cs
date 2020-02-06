using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using api.ejercicio.models;
using Microsoft.AspNetCore.Mvc;

namespace api.ejercicio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PositionHistoryController : ControllerBase
    {

        [HttpGet]        
        public IList<Vehicle> Get(DateTime from, DateTime to)
        {
            var resultado = new List<Vehicle>();

            /*
            1. abrir la conexión con la base de datos
            2. Abrir la consulta / generar el comando
            3. Abrir el reader / interpretar resultados
            */

            // Abrir la conexión a la base de datos
            var connectionString = "alguna connection string";
            var connection = new SqlConnection(connectionString);
            connection.Open();

            // Hacer la consulta / ejecutar el comando

            var sql = string.Format(@"
                SELECT d.id AS driverId, d.lastname, d.firstname, d.phone, d.email, 
                    v.name AS vehiclename, v.licenseplate, v.id As vehicleID, 
                    g.latitude, g.longitude, g.id AS positionid, g.timestamp
                FROM vehicle v
                    INNER JOIN driver d ON (v.driverid = d.id)
                    INNER JOIN gpsreporthistory g ON (g.vehicleid=v.id)
                WHERE g.timestamp BETWEEN '{0}' AND '{1}'
            ", from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));

            var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();

            // inrepretar los resultados

            while (reader.Read())
            {
                var vehicleid = reader.GetInt32(7);
                var vehicle = resultado.Where(v => v.Id == vehicleid).SingleOrDefault();

                if (vehicle == null)
                {
                    vehicle = new Vehicle();
                    vehicle.Position = new List<Position>();

                    vehicle.Id = reader.GetInt32(7);
                    vehicle.Name = reader.GetString(5);
                    vehicle.LicensePlate = reader.GetString(6);

                    vehicle.Driver = new Driver
                    {
                        Id = reader.GetInt32(0),
                        LastName = reader.GetString(1),
                        FirstName = reader.GetString(2),
                        Phone = reader.GetString(3),
                        Email = reader.GetString(4)
                    };

                    resultado.Add(vehicle);
                }
                
                vehicle.Position.Add(new Position
                {
                    Id = reader.GetInt32(10),
                    Latitude = reader.GetDouble(8),
                    Longitude = reader.GetDouble(9),
                    Instant = reader.GetDateTime(11)
                });
            }
            return resultado;
        }
    }
}