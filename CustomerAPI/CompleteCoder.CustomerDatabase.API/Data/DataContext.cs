using CompleteCoder.CustomerDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CompleteCoder.CustomerDatabase.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext() :base("DefaultConnection")
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}