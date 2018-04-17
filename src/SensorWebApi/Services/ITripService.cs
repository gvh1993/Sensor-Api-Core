using SensorApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorApi.Services
{
    public interface ITripService
    {
        bool Add(Trip trip);
        IEnumerable<Trip> GetAll();

    }
}
