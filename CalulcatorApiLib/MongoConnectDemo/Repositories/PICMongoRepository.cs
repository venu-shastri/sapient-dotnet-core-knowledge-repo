using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
namespace MongoConnectDemo.Repositories
{
    public class PICMongoRepository
    {
        IConfiguration _configuration;
        IMongoCollection<Models.User> _users;
        
        public PICMongoRepository(IConfiguration configuration)
        {
            this._configuration = configuration;
            string connectionString = this._configuration.GetConnectionString("MongoDataBaseConnetcionString");
            var client = new MongoClient(MongoClientSettings.FromConnectionString(connectionString));
            var database = client.GetDatabase("pic");
            _users = database.GetCollection<Models.User>("users");
        }

        public async Task<List<Models.User>> GetAllAsync()
        {
            return await _users.Find(c => true).ToListAsync();
        }
    }
}
