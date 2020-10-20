using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    public class Book
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string title { get; set; }

        public string publisher { get; set; }

        public bool isRented { get; set; }

        public string userRented { get; set; }

        

    }
}
