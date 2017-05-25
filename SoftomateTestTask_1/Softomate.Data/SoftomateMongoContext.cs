using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softomate.Entity;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Softomate.Data
{
    public class SoftomateMongoContext : DbContext
    {
        public SoftomateMongoContext()//: base(@"Server=localhost:27017;Database=softomate_test;")
        {
            ;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // To remove the requests to the Migration History table
            Database.SetInitializer<SoftomateMongoContext>(null);
            // To remove the plural names   
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<PeopleMongo> PeopleMongo { set; get; }
        ////private string connectionString = "mongodb://localhost";
        ////IMongoDatabase database = client.GetDatabase("softomate_test");
        ////var collection = database.GetCollection<People>("softomate");
        //private string connectionString;
        //private string dbName;
        //private string collName;
        ////private List<People> people;
        //public SoftomateMongoContext(string connectionString, string dbName, string collName)
        //{
        //    this.connectionString = connectionString;
        //    this.dbName = dbName;
        //    this.collName = collName;
        //    //MongoClient client = new MongoClient(connectionString);
        //    //IMongoDatabase database = client.GetDatabase("softomate_test");
        //    //var collection = database.GetCollection<People>("softomate");
        //    //var filter = new BsonDocument();
        //    //people = collection.Find(filter).ToList();
        //}

        //public List<People> People()
        //{
        //    MongoClient client = new MongoClient(connectionString);
        //    IMongoDatabase database = client.GetDatabase(dbName);
        //    var collection = database.GetCollection<People>(collName);
        //    //var filter = new BsonDocument();
        //    return collection.Find(new BsonDocument()).ToList();
        //}

        //public List<People> People {get {return people;

    }
}
