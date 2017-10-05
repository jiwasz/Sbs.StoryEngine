using System;
using System.Collections.Generic;
using System.Text;

namespace SmallBasketStudios.Audio.Models.Configuration
{

    public enum ConnectionType
    {
        Mongo = 1

    }
    public class DbConnections
    {
        public ConnectionType DbType { get; set; }

        public MongoDb MongoDb { get; set; }
    }



}
