using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TennisTracker.Models;

namespace TennisTracker.Service
{
    public class SinglesMatchService
    {
        private readonly SinglesMatchRepository _singlesMatchRepository; 

        public SinglesMatchService(SinglesMatchRepository singlesMatchRepository)
        {
            _singlesMatchRepository = singlesMatchRepository;
        }

        public Dictionary<int,string> CalculateWinLoss(int playerId)
        {
            var singlesMatches =
            _singlesMatchRepository.GetAllSinglesMatches();

            var playersSinglesMatches =
            singlesMatches.Where(sm => sm.Player1Id == playerId || sm.Player2Id == playerId);

            var totalMatches = playersSinglesMatches.Count();

            var playerWins = playersSinglesMatches.Where(sm => sm.PlayerIdWinner == playerId).Count();

            var winLossString = string.Format("{0},{1}", totalMatches, playerWins);

            var winLoss = new Dictionary<int, string>();

            winLoss.Add(playerId, winLossString);

            return winLoss;
        } 
    }
}