using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using SensorApi.Helpers;
using SensorApi.Models;
using SensorWebApi;

namespace SensorApi.Repositories
{
    public class TripRepository : ITripRepository
    {
        IMongoDatabase db;
        IMongoCollection<Trip> tripCollection;
        public TripRepository()
        {
            
            db = new MongoDBManager().Db;
            tripCollection = db.GetCollection<Trip>("Trip");
        }

        public bool Add(Trip trip)
        {
            try
            {
                tripCollection.InsertOne(trip);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public Trip Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trip> GetAll()
        {
            try
            {
                return tripCollection.Find(_ => true).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Trip>();
            }
        }

        public void Remove(Trip entity)
        {

        }
    }
}