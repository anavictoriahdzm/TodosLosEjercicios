using ExpressoApiNet.Data;
using ExpressoApiNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExpressoApiNet.Controllers
{
    public class ReservationsController : ApiController
    {
        ExpressoDbContext expressoDbContext = new ExpressoDbContext();

        public IHttpActionResult Get()
        {
            var reservation = expressoDbContext.Reservations;
            return Ok(reservation);

        }

        public IHttpActionResult Post(Reservation reservation)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            expressoDbContext.Reservations.Add(reservation);
            expressoDbContext.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }
    }
}
