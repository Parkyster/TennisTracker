using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace TennisTracker.Models
{
    public class TennisTrackerContextInitializer : DropCreateDatabaseAlways<TennisTrackerContext>
    {
        protected override void Seed(TennisTrackerContext context)
        {

            var players = new List<Player>
            {
                new Player()
                {
                    Name = "Jonathan",
                    FavouriteSurface = "Clay",
                    Plays = "Right",
                    Sex = "Male"
                },
                new Player()
                {
                    Name = "Richard",
                    FavouriteSurface = "Hard",
                    Plays = "Right",
                    Sex = "Male"
                },
                new Player()
                {
                    Name = "David",
                    FavouriteSurface = "Hard",
                    Plays = "Right",
                    Sex = "Male"
                },
                new Player()
                {
                    Name = "Alex",
                    FavouriteSurface = "Hard",
                    Plays = "Right",
                    Sex = "Male"
                },
                new Player()
                {
                    Name = "Gareth",
                    FavouriteSurface = "Grass",
                    Plays = "Left",
                    Sex = "Male"
                },
                new Player()
                {
                    Name = "Nick",
                    FavouriteSurface = "Hard",
                    Plays = "Left",
                    Sex = "Male"
                },
                new Player()
                {
                    Name = "Nick",
                    FavouriteSurface = "Hard",
                    Plays = "Left",
                    Sex = "Male"
                },
            };
            players.ForEach(p => context.Players.Add(p));
            context.SaveChanges();

            var playerRecords = new List<PlayerRecord>
            {
        

            };
            playerRecords.ForEach(p => context.PlayerRecords.Add(p));
            context.SaveChanges();
            base.Seed(context);

            var SinglesMatches = new List<SinglesMatch>()
            {
                new SinglesMatch()
                {
                    Date = DateTime.Now,
                    Venue = new Venue().Name = "Rodborough",
                    Player1Id = players[1].PlayerId,
                    Player2Id = players[2].PlayerId,
                    Score = "6-4, 6-4"
                                     
                    
                },
                new SinglesMatch()
                {
                    Date = DateTime.Now,
                    Venue = new Venue().Name = "Rodborough",
                    Player1Id = players[2].PlayerId,
                    Player2Id = players[3].PlayerId,
                    Score = "6-1, 6-2"
                },
                 new SinglesMatch()
                {
                    Date = DateTime.Now,
                    Venue = new Venue().Name = "Busbridge",
                    Player1Id = players[1].PlayerId,
                    Player2Id = players[4].PlayerId,
                    Score = "6-1, 6-3"
                },


            };
            SinglesMatches.ForEach(sm => context.SinglesMatches.Add(sm));
            context.SaveChanges();
            base.Seed(context);

            var doublesMatches = new List<DoublesMatch>()
            {
                new DoublesMatch()
                {
                    Date = DateTime.Now,
                    Venue = new Venue().Name = "Broadwater",
                    Player1Id = players[1].PlayerId,
                    Player2Id = players[2].PlayerId,
                    Player3Id = players[3].PlayerId,
                    Player4Id = players[4].PlayerId,
                    Winners = new KeyValuePair<int, int>(players[1].PlayerId, players[2].PlayerId),
                    Score = "6-1,6-2,6-3",
                },
            };
                doublesMatches.ForEach(dm => context.DoublesMatches.Add(dm));
            context.SaveChanges();
            base.Seed(context);

            var venues = new List<Venue>()
            {
                new Venue()
                {
                    Name = "Broadwater",
                    CourtType = "Hard",
                },
            };

            venues.ForEach(v => context.Venues.Add(v));
            context.SaveChanges();
            base.Seed(context);


        }
    }
}