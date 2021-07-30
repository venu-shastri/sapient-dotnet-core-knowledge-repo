using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoSqlConnectivityDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IMongoCollection<Models.User> users = null;
        public UsersController()
        {
           var settings= MongoClientSettings.FromConnectionString("mongodb+srv://venu:tEdrJKhyoxnUD9FP@cluster0.npou2.mongodb.net/pic?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var dataBase = client.GetDatabase("pic");
            this.users = dataBase.GetCollection<Models.User>("users");

        }

        [HttpGet]
        public IList<Models.User> Get()
        {
            return this.users.Find(user=>true).ToList();
        }
    }
}
