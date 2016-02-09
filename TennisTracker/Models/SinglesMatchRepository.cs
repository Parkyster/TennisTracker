using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace TennisTracker.Models
{
    public class SinglesMatchRepository
    {
        private readonly TennisTrackerContext _entities;

        public SinglesMatchRepository(TennisTrackerContext dbContext)
        {
            _entities = dbContext;
        }

        public virtual IEnumerable<SinglesMatch> GetAllSinglesMatches()
        {
            return _entities.SinglesMatches.OrderBy(p => p.SinglesMatchId).ToList();



        }

        public virtual SinglesMatch GetSinglesMatch(int singlesMatchId)
        {
            return _entities.SinglesMatches.First(sm => sm.SinglesMatchId == singlesMatchId);
        }

    }
}