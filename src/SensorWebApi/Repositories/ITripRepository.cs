using MongoDB.Bson;
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
        bool Delete(ObjectId id);
        bool Update(Trip trip);
    }
}
