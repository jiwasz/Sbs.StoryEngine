using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using SmallBasketStudios.Audio.Models;

namespace SmallBasketStudios.Audio.Data.MongoDb
{

    /// <summary>
    /// Resposible for AudioTitle CRUD operations.
    /// </summary>
    public class MongoDbTitleRepository : ITitleRepository

    {
        private const string AudioTitleColName = "Title";
        private const string SkillIdColName = "SkillId";
        private const string CollectionName = "Title";

        private IMongoDatabase _monDb;
        public MongoDbTitleRepository(IMongoDatabase mongoDb)
        {

            _monDb = mongoDb;
        }

        public Task CreateTitle(AudioTitle title)
        {
            var audioCol = _monDb.GetCollection<AudioTitle>(AudioTitleColName);
            var insertTask = audioCol.InsertOneAsync(title);
            return insertTask;
        }

        public async Task<AudioTitle> GetBySkillId(string skillId)
        {
            return await GetByValue(SkillIdColName, skillId);
        }

        public async Task<AudioTitle> GetByTitle(string title)
        {
            return await GetByValue(AudioTitleColName, title);
        }

        private async Task<AudioTitle> GetByValue(string columnName, string value)
        {
            var audioCol = _monDb.GetCollection<AudioTitle>(AudioTitleColName);

            var filter = Builders<AudioTitle>.Filter.Eq(columnName, value);

            var result = await audioCol.Find(filter).ToListAsync();

            if (result.Count == 1)
            {
                return result[0];
            }

            return null;
        }


    }
}
