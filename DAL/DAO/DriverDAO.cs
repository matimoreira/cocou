using System.Collections.Generic;
using System.Data.SqlClient;
using api.ejercicio.DAO.DTO;

namespace api.ejercicio.DAO
{
    public class DriverDAO
    {
        string connectionString = "holis";
        SqlConnection connection;

        public DriverDAO()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        ~DriverDAO()
        {
            connection.Close();
        }

        public IList<DriverDTO> GetAll()
        {
            var sql = "SElECT id, firstname, lastname, phone, email FROM driver";
            var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();

            var drivers = new List<DriverDTO>();
            while (reader.Read())
            {
                drivers.Add
                (
                    new DriverDTO
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Phone = reader.GetString(3),
                        Email = reader.GetString(4),
                    }
                );
            }
            
            return drivers;
        }
        
        public DriverDTO GetbyId(int id)
        {
            return null;
        }

        public bool Save(DriverDTO driver)
        {
            return true;
        }

        public bool Delete (DriverDTO driver)
        {
            return true;
        }
    }
}

