using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TennisTracker.Models;

namespace TennisTracker.Controllers
{
    public class PlayerRecordController : ApiController
    {
        private TennisTrackerContext db = new TennisTrackerContext();

        // GET api/PlayerRecord
        public IEnumerable<PlayerRecord> GetPlayerRecords()
        {
            return db.PlayerRecords.AsEnumerable();
        }

        // GET api/PlayerRecord/5
        public PlayerRecord GetPlayerRecord(int id)
        {
            PlayerRecord playerrecord = db.PlayerRecords.Find(id);
            if (playerrecord == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return playerrecord;
        }

        // PUT api/PlayerRecord/5
        public HttpResponseMessage PutPlayerRecord(int id, PlayerRecord playerrecord)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != playerrecord.Id)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(playerrecord).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/PlayerRecord
        public HttpResponseMessage PostPlayerRecord(PlayerRecord playerrecord)
        {
            if (ModelState.IsValid)
            {
                db.PlayerRecords.Add(playerrecord);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, playerrecord);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = playerrecord.Id }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/PlayerRecord/5
        public HttpResponseMessage DeletePlayerRecord(int id)
        {
            PlayerRecord playerrecord = db.PlayerRecords.Find(id);
            if (playerrecord == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.PlayerRecords.Remove(playerrecord);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, playerrecord);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}