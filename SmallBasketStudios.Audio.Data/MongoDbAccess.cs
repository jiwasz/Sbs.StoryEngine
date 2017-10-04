using System;
using System.Collections.Generic;
using System.Text;
using MongoDB;
using MongoDB.Driver;

namespace SmallBasketStudios.Audio.Data
{

    /// <summary>
    /// Handles access directly to the Mongo DB database.
    /// </summary>
    internal static class MongoDbAccess
    {

        private static IMongoClient _client;

        private static Lazy<IMongoDatabase> _mongDb = new Lazy<IMongoDatabase>(() =>
        {
              var monClient = new MongoClient();
               var monDb = monClient.GetDatabase("sbsaudio");

            return monDb;
        });


        internal static  IMongoDatabase AudioDb
        {
            get
            {
                return _mongDb.Value;

            }

        }

 
//etc...
 
//Create a default mongo object. This handles our connections to the database.
//By default, this will connect to localhost, 
//port 27017 which we already have running from earlier.
//var mongo = new Mongo();
//    mongo.Connect();
 
//Get the blog database. If it doesn't exist, that's ok because MongoDB will create it 
//for us when we first use it. Awesome!!!
//var db = mongo.GetDatabase("blog");


}
}
