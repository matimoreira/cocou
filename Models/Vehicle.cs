using System.Collections.Generic;

namespace api.ejercicio.models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LicensePlate { get; set; }
        public Driver Driver { get; set; }
        public IList<Position> Position { get; set; }
    }
}