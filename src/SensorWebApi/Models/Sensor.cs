using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SensorApi.Models
{
    public class Sensor
    {
        public DateTimeOffset Timestamp { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}