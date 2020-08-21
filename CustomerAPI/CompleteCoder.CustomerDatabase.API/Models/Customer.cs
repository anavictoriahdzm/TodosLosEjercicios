using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompleteCoder.CustomerDatabase.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Name { get; set; }

        public Customer()
        {
            this.Id = Guid.NewGuid().ToString();
            this.DateCreated = DateTime.Now;
        }
    }
}