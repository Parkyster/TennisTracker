using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TennisTracker.Models;
using TennisTracker.Service;

namespace TennisTracker.Controllers
{
    public class PlayersController : Controller
    {
        private PlayersRepository _playerRepository;

        public ActionResult Index()
        {     
             var dbContext = new TennisTrackerContext();
            _playerRepository = new PlayersRepository(dbContext);
            var players = _playerRepository.GetAllPlayers();
            var singlesMatchRepository = new SinglesMatchRepository(dbContext);
            var singlesMatchService = new SinglesMatchService(singlesMatchRepository);

            var winLossDictionary = new List<Dictionary<int, string>>();
            foreach (var player in players)
            {
                var winLoss =
                singlesMatchService.CalculateWinLoss(player.PlayerId);
                winLossDictionary.Add(winLoss);
            }

            var playersWithWinLoss = new PlayersWithWinLoss(players, winLossDictionary);

            return View(playersWithWinLoss);
        }



    }
}
