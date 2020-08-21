using QuotesApi.Data;
using QuotesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuotesApi.Controllers
{
    public class QuotesDbController : ApiController
    {
        QuotesDbContext1 quotesDbContext = new QuotesDbContext1();
        // GET: api/QuotesDb
        [HttpGet]
        public IHttpActionResult LoadQuotes(string sort)
        {
            IQueryable<Quote> quotes;
            switch (sort)
            {
                case "desc":
                    quotes = quotesDbContext.Quotes.OrderByDescending(q => q.CreatedAt);
                    break;
                case "asc":
                    quotes = quotesDbContext.Quotes.OrderBy(q => q.CreatedAt);
                    break;
                default:
                    quotes = quotesDbContext.Quotes;
                    break;
            }
            //var quotes = quotesDbContext.Quotes;
            return Ok(quotes);
        }
        /*public IEnumerable<Quote> Get()
        {
            return quotesDbContext.Quotes;
        }*/

        [HttpGet]
        [Route("api/QuotesDb/PaginQuote/{pageNumber=}/{pageSize=}")]
        public IHttpActionResult PaginQuote(int pageNumber, int pageSize)
        {
            var quotes = quotesDbContext.Quotes.OrderBy(q => q.Id);
            return Ok(quotes.Skip((pageNumber -1)*pageSize).Take(pageSize));
        }

        [HttpGet]
        [Route("api/QuotesDb/SearchQuotes/{type}")]
        public IHttpActionResult SearchQuotes(string type)
        {
            var quotes = quotesDbContext.Quotes.Where(q => q.Type.StartsWith(type));
            return Ok(quotes);
        }

        // GET: api/QuotesDb/5
        [HttpGet]
        public IHttpActionResult LoadQuote(int id)
        {
            var quote = quotesDbContext.Quotes.Find(id);
            if (quote == null)
                return NotFound();
            return Ok(quote);
        }
        /*public Quote Get(int id)
        {
            var quote = quotesDbContext.Quotes.Find(id);
            return quote;
        }*/

        // POST: api/QuotesDb
        [HttpPost]
        public IHttpActionResult Post([FromBody]Quote quote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            quotesDbContext.Quotes.Add(quote);
            quotesDbContext.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }
        /*public void Post([FromBody]Quote quote)
        {
            quotesDbContext.Quotes.Add(quote);
            quotesDbContext.SaveChanges();
        }*/

        // PUT: api/QuotesDb/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]Quote quote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = quotesDbContext.Quotes.FirstOrDefault(q => q.Id == id);
            if (entity == null)
            {
                return BadRequest("No record found against this id");
            }
            entity.Title = quote.Title;
            entity.Author = quote.Author;
            entity.Description = quote.Description;
            quotesDbContext.SaveChanges();
            return Ok("Record updated successfully...");
        }
        /*public void Put(int id, [FromBody]Quote quote)
        {
            var entity = quotesDbContext.Quotes.FirstOrDefault(q => q.Id == id);
            entity.Title = quote.Title;
            entity.Author = quote.Author;
            entity.Description = quote.Description;
            quotesDbContext.SaveChanges();
        }*/

        // DELETE: api/QuotesDb/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var quote = quotesDbContext.Quotes.Find(id);
            if (quote == null)
                return BadRequest("No record found against this id");

            quotesDbContext.Quotes.Remove(quote);
            quotesDbContext.SaveChanges();
            return Ok("Quote deleted");
        }
        /*public void Delete(int id)
        {
            var quote = quotesDbContext.Quotes.Find(id);
            quotesDbContext.Quotes.Remove(quote);
            quotesDbContext.SaveChanges();
        }*/
    }
}
