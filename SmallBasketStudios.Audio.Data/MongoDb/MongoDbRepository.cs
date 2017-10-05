using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using MongoDB.Driver;
using SmallBasketStudios.Audio.Models;

namespace SmallBasketStudios.Audio.Data.MongoDb
{
    //public class MongoDbRepository : IDataRepository
    //{
    //    private IMongoDatabase _db;
    //    private IMongoClient _client;

    //    public MongoDbRepository(string constr, string dbname)
    //    {
    //        _client= new MongoClient(constr);
    //        _db = _client.GetDatabase(dbname);
    //    }

    //    private IMongoCollection<T> GetCollection<T>() where T : IAudioEntity, new()
    //    {
    //        return _db.GetCollection<T>(typeof(T).Name);
    //    }

    //    public IEnumerable<T> List<T>() where T :IAudioEntity, new()
    //    {
    //        return GetCollection<T>().FindSync(_ => true).ToEnumerable();
    //    }
        
    //    public IEnumerable<T> List<T>(Expression<Func<T, bool>> exp) where T : IAudioEntity, new()
    //    {
    //        return GetCollection<T>().AsQueryable<T>().Where(exp);
    //    }

    //    public T Single<T>(Expression<Func<T, bool>> exp) where T : IAudioEntity, new()
    //    {
    //        return List<T>(exp).SingleOrDefault();
    //    }

    //    public void Insert<T>(T entity) where T : IAudioEntity, new()
    //    {
    //        GetCollection<T>().InsertOne(entity);
    //    }

    //    public void Insert<T>(ICollection<T> entities) where T : IAudioEntity, new()
    //    {
    //        GetCollection<T>().InsertMany(entities);
    //    }
    //}

}
