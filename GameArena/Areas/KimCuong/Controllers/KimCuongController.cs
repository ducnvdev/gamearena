using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GameArena.Areas.KimCuong.Models;
using MongoDB.Driver;

namespace GameArena.Areas.KimCuong.Controllers
{
    public class KimCuongController : ApiController
    {
        public DataModel<object> PlayGame()
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("test");
            var collection = database.GetCollection<DataModel<object>>("entities");
            return new DataModel<object>();
        }
    }
}
