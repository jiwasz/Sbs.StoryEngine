using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using SmallBasketStudios.Audio.Repository.Models;

namespace SmallBasketStudios.Audio.Data
{

    /// <summary>
    /// Resposible for AudioTitle CRUD operations.
    /// </summary>
    public static class AudioTitleManager
    {
        private const string AudioTitleColName = "Title";


        public static  Task  CreateTitle(AudioTitle title)
        {
            var audioCol = MongoDbAccess.AudioDb.GetCollection<AudioTitle>(AudioTitleColName);
            var insertTask = audioCol.InsertOneAsync(title);
            return insertTask;
        }

        public async static Task<AudioTitle> GetTitle(string title)
        {
  
            var audioCol = MongoDbAccess.AudioDb.GetCollection<AudioTitle>(AudioTitleColName);
            var filter = Builders<AudioTitle>.Filter.Eq("Title", title);

            var result = await audioCol.Find(filter).ToListAsync();

           if(result.Count == 1)
            {
                return result[0];

            }

            return null;
        }


    }
}
