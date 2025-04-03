
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoProject.Settings;

namespace MongoProject.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IOptions<MongoDBSettings> _settings;
        private readonly IMongoCollection<T> _mongoCollection;
        public Repository(IOptions<MongoDBSettings> settings)
        {
            _settings = settings;
            var client = new MongoClient(_settings.Value.MongoDBConnection);
            var database = client.GetDatabase(_settings.Value.DatabaseName);
            _mongoCollection = database.GetCollection<T>(typeof(T).Name);
        }
        public async Task<T> CreateAsync(T entity)
        {
            await _mongoCollection.InsertOneAsync(entity);

            return entity;
        }

        public async Task DeleteAsync(string id)
        {
            var objectId = new ObjectId(id);
            await _mongoCollection.DeleteOneAsync(Builders<T>.Filter.Eq("_id", objectId));
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _mongoCollection.Find(_ => true).ToListAsync();
        }

        public Task<T> GetByIdAsync(string id)
        {
            var objectId = new ObjectId(id);
            return _mongoCollection.Find(Builders<T>.Filter.Eq("_id", objectId)).FirstOrDefaultAsync();
        }

        public async Task<T> UpdateAsync(string id, T entity)
        {
            var objectId = new ObjectId(id);
            await _mongoCollection.ReplaceOneAsync(Builders<T>.Filter.Eq("_id", objectId), entity);
            return entity;
        }
    }
}
