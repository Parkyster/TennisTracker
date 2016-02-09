using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TennisTracker.Models;
using TennisTracker.Service;

namespace TennisTracker.Controllers
{
    public class SinglesMatchesController : Controller
    {
        private SinglesMatchRepository _singlesMatchRepository;

        public ActionResult Index()
        {
            var dbContext = new TennisTrackerContext();
            var singlesMatchRespotiory = new SinglesMatchRepository(dbContext);
            _singlesMatchRepository = singlesMatchRespotiory;

            var singlesMatches =
                _singlesMatchRepository.GetAllSinglesMatches();

            return View(singlesMatches);
        }
    }
}
