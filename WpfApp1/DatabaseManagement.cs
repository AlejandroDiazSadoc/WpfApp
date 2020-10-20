using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace WpfApp1
{
    public class DatabaseManagement
    {
        public static DatabaseManagement instance;

        private MongoClient client { get; }

        private IMongoDatabase db { get; }

        public IMongoCollection<User> Users { get;  }

        public IMongoCollection<Book> Books { get; }
        public DatabaseManagement()
        {
            instance = this;

            //only for testing purposes
            client = new MongoClient("mongodb://prueba:prueba1@ds137650.mlab.com:37650/wpfapp?retryWrites=false");
            
            db = client.GetDatabase("wpfapp");

            Users = db.GetCollection<User>("Users");

            Books = db.GetCollection<Book>("Books");

        }

        
    }
}
