using System.Data.Entity;

namespace TennisTracker.Models
{
    public class TennisTrackerContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<TennisTracker.Models.TennisTrackerContext>());

        public TennisTrackerContext() : base("name=TennisTrackerContext")
        {
           
        }


        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerRecord> PlayerRecords { get; set; }
        public DbSet<SinglesMatch> SinglesMatches { get; set; }
        public DbSet<DoublesMatch> DoublesMatches { get; set; }
        public DbSet<Venue> Venues { get; set; } 
    }
}
