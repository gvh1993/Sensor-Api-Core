using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SensorApi.Models
{
    public class MeasurementSession
    {
        public DateTimeOffset Timestamp { get; set; }
        //battery
        public int BatteryPercent { get; set; }
        public string BatteryStatus { get; set; }

        //pedometer
        public int Pedometer { get; set; }

        //proximity
        public bool Proximity { get; set; }

        //compass
        public int Compass { get; set; }

        //ambient light
        public int AmbientLight { get; set; }
    }
}