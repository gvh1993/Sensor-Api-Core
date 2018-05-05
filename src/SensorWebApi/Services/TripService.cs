using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using SensorApi.Models;
using SensorApi.Repositories;

namespace SensorApi.Services
{
    public class TripService : ITripService
    {
        private ITripRepository _tripRepository;

        public TripService()
        {
            _tripRepository = new TripRepository();
        }

        public bool Add(Trip trip)
        {
            return _tripRepository.Add(trip);
        }

        public IEnumerable<Trip> GetAll()
        {
            return _tripRepository.GetAll();
        }

        public bool Delete(ObjectId id)
        {
            return _tripRepository.Delete(id);
        }

        public bool Update(Trip trip)
        {
            return _tripRepository.Update(trip);
        }
    }
}