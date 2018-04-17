using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using SensorApi.Models;
using SensorApi.Services;

namespace SensorApi.Controllers
{
    [Route("api/[Controller]")]
    public class TripController : Controller
    {
        private ITripService _tripService;

        public TripController()
        {
            _tripService = new TripService();   
        }

        // GET: api/Trip
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            try
            {
                 var trips = _tripService.GetAll();
                return Ok(trips);
            }
            catch (Exception e){
                return StatusCode(500);
            }
            
        }

        // GET: api/Trip/5
        public string Get(Trip id)
        {
            return "value";
        }

        // POST: api/Trip
        [HttpPost]
        [Route("Post")]
        public IActionResult Post([FromBody]Trip trip)
        {
            try
            {
                bool insertSuccess = _tripService.Add(trip);
                if (!insertSuccess)
                {
                    return StatusCode(500);
                }
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        // DELETE: api/Trip/5
        public void Delete(int id)
        {
        }
    }
}
