using SensorApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorApi.Repositories
{
    public interface ITripRepository
    {
        bool Add(Trip entity);
        Trip Get();
        IEnumerable<Trip> GetAll();
        void Remove(Trip entity);
    }
}
