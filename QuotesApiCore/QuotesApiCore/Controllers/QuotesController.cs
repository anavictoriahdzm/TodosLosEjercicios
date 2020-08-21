using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuotesApiCore.Data;
using QuotesApiCore.Models;

namespace QuotesApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class QuotesController : ControllerBase
    {
        private QutesDbContext _qoutesDbContext;

        public QuotesController(QutesDbContext qutesDbContext)
        {
            _qoutesDbContext = qutesDbContext;
        }
        // GET: api/Quotes
        [HttpGet]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)] 
        /*public IEnumerable<Quote> Get()
        {
            return _qoutesDbContext.Quotes;
        }*/
        public IActionResult Get(string sort)
        {
            IEnumerable<Quote> quotes;
            switch (sort)
            {
                case "desc":
                    quotes = _qoutesDbContext.Quotes.OrderByDescending(q => q.CreatedAt);
                    break;
                case "asc":
                    quotes = _qoutesDbContext.Quotes.OrderBy(q => q.CreatedAt);
                    break;
                default:
                    quotes = _qoutesDbContext.Quotes;
                    break;
            }
            return Ok(quotes);
        }

        [HttpGet("[action]")]
        public IActionResult PagingQuote(int? pageNumber, int? pageSize)
        {
            //Para usar el result comentado necesitamos quitar los signos de pregunta (?) en los parametros y comentar las variables currentPageNumber y currentePageSize
            var quetes = _qoutesDbContext.Quotes;
            var currentPageNumber = pageNumber ?? 1;
            var currentPageSize = pageSize ?? 5;

            //return Ok(quetes.Skip((pageNumber-1)*pageSize).Take(pageSize));
            return Ok(quetes.Skip((currentPageNumber -1 )* currentPageSize).Take(currentPageSize));
        }

        [HttpGet]
        [Route("action")]
        public IActionResult SearchQuote(string type)
        {
            var quotes = _qoutesDbContext.Quotes.Where(q => q.Type.StartsWith(type));
            return Ok(quotes);
        }

        // GET: api/Quotes/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var quote = _qoutesDbContext.Quotes.Find(id);
            if (quote == null)
            {
                return NotFound("No reocrd found...");
            }
            return Ok(quote);
        }

        /*public Quote Get(int id)
        {
            var quote = _qoutesDbContext.Quotes.Find(id);
            return quote;
        }*/

        // POST: api/Quotes
        [HttpPost]
        public IActionResult Post([FromBody] Quote quote)
        {
            _qoutesDbContext.Quotes.Add(quote);
            _qoutesDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
        /*public void Post([FromBody] Quote quote)
        {
            _qoutesDbContext.Quotes.Add(quote);
            _qoutesDbContext.SaveChanges();
        }*/

        // PUT: api/Quotes/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Quote quote)
        {
            var entity = _qoutesDbContext.Quotes.Find(id);
            if (entity==null)
            {
                return NotFound("No record found against this id... ");
            }
            else
            {
                entity.Title = quote.Title;
                entity.Author = quote.Author;
                entity.Description = quote.Description;
                entity.Type = quote.Type;
                entity.CreatedAt = quote.CreatedAt;
                _qoutesDbContext.SaveChanges();
                return Ok("Record updated successfully...");
            }
        }
        /*public void Put(int id, [FromBody] Quote quote)
        {
            var entity = _qoutesDbContext.Quotes.Find(id);
            entity.Title = quote.Title;
            entity.Author = quote.Author;
            entity.Description = quote.Description;
            _qoutesDbContext.SaveChanges();
        }*/

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delere(int id)
        {
            var quote = _qoutesDbContext.Quotes.Find(id);
            if (quote == null)
            {
                return NotFound("No reocrd found against this id...");
            }
            else
            {
                _qoutesDbContext.Quotes.Remove(quote);
                _qoutesDbContext.SaveChanges();
                return Ok("Quote deleted...");
            }
        }
        /*public void Delete(int id)
        {
            var quote = _qoutesDbContext.Quotes.Find(id);
            _qoutesDbContext.Quotes.Remove(quote);
            _qoutesDbContext.SaveChanges();
        }*/
    }
}
