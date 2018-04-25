using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SensorApi.Models
{
    public class Gps
    {
        public DateTimeOffset Timestamp { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public float Speed { get; set; }
        public float Accuracy { get; set; }
        public float Bearing { get; set; }
        public double Altitude { get; set; }
    }
}