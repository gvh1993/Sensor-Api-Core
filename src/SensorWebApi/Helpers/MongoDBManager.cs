using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SensorWebApi;

namespace SensorApi.Helpers
{
    public class MongoDBManager
    {
        private readonly IConfiguration configuration;

        public IMongoDatabase Db { get; set; }

        public MongoDBManager()
        {
            MongoClient client = new MongoClient(Startup.ConnectionString);
            Db = client.GetDatabase("sensor");
        }

        private IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);


            builder = builder.AddEnvironmentVariables();

            return builder.Build();
        }
    }
}
