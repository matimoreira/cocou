using System;

namespace api.ejercicio.models
{
    public class Position
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Instant { get; set; }
    }
}