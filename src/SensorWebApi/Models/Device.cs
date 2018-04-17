using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SensorApi.Models
{
    public class Device
    {
        public string Model { get; set; }
        public string OperatingSystem { get; set; }
        public string Id { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
    }
}