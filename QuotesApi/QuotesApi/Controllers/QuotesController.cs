using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuotesApi.Models;

namespace QuotesApi.Controllers
{
    public class QuotesController : ApiController
    {
        //ESTE CONTROLLER SE UTILIZO PARA HACER PRUEBAS SIN DATABASE
        //PERO NO LO ELIMINO PARA SABER QUE ONDA
        static List<Quote> _quotes = new List<Quote>()
        {
            new Quote(){Id=0, Author = "Einstein", Description="Imagination is more important thank knowledge", Title = "Imagination"},
            new Quote(){Id=1, Author = "Einstein", Description="Imagination is more important thank knowledge", Title = "Imagination"},
        };

        public IEnumerable<Quote> Get()
        {
            return _quotes;
        }

        public void Post([FromBody]Quote quote)
        {
            _quotes.Add(quote);
        }

        public void Put(int id , [FromBody] Quote quote)
        {
            _quotes[id] = quote;
        }

        public void Delete(int id)
        {
            _quotes.RemoveAt(id);
        }
    }
}
