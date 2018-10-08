using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace SensorApi.Models
{
    public class Trip
    {
        public ObjectId Id { get; set; }
        public DateTimeOffset BeginDateTimeOffset { get; set; }
        public DateTimeOffset EndDateTimeOffset { get; set; }
        public List<TransportMode> TransportationModes { get; set; }
        public int StepCount { get; set; }
        public List<Accuracy> Accuracies { get; set; }
        public List<Gps> Gpses { get; set; }
        public List<Accelerometer> Accelerometers { get; set; }
        public List<Gyroscope> Gyroscopes { get; set; }
        public List<Magnetometer> Magnetometers { get; set; }
        public List<LinearAcceleration> LinearAccelerations { get; set; }
        public List<Gravity> Gravities { get; set; }
        public List<Orientation> Orientations { get; set; }
        public List<RotationVector> RotationVectors { get; set; }
    }
}