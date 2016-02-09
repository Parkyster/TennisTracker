using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TennisTracker.Models
{
    public class PlayersRepository
    {
        private TennisTrackerContext _entities;

        public PlayersRepository(TennisTrackerContext dbContext)
        {
            _entities = dbContext;
        }

        public virtual IEnumerable<Player> GetAllPlayers()
        {
            return _entities.Players.OrderBy(p => p.Name).ToList();
        }

        public virtual Player GetPlayer(int playerId)
        {
            return _entities.Players.First(p => p.PlayerId == playerId);
        }

        public virtual Player AddPlayer(Player player)
        {
            return _entities.Players.Add(player);
        }

    }
}