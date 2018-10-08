using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorApi.Models
{
    public class Accuracy
    {
        public DateTimeOffset Timestamp { get; set; }
        public string Sensor { get; set; }
        public string AccuracyCategory { get; set; }
    }
}
