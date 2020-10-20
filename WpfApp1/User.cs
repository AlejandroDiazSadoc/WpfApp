using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace WpfApp1
{
    public class User
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string username { get; set; }

        public string password { get; set; }

        public string role { get; set; }
    }
}
