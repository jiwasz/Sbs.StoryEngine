using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using SmallBasketStudios.Audio.Data.MongoDb;
using SmallBasketStudios.Audio.Models.Configuration;

namespace SmallBasketStudios.Audio.Data
{
    public static class RepositoryFactory
    {
        private static Lazy<IMongoDatabase> _mongDb = new Lazy<IMongoDatabase>(() =>
        {
            var monClient = new MongoClient();
            var monDb = monClient.GetDatabase("sbsaudio");

            return monDb;
        });

        public static ITitleRepository GetTitleRepository(DbConnections cons)
        {
            ITitleRepository titleRep = null;

          switch(cons.DbType)
            {
                case ConnectionType.Mongo:
                    IMongoDatabase monDb = GetMongoClient(cons.MongoDb);
                    titleRep = new MongoDbTitleRepository(monDb);
                    break;
            }


            return titleRep;
        }

        private static IMongoDatabase GetMongoClient(SmallBasketStudios.Audio.Models.Configuration.MongoDb config)
        {

            var monClient = new MongoClient(config.ConnectionString);
            var monDb = monClient.GetDatabase(config.AudioDb);

            return monDb;
        }
    }
}
