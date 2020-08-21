using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuotesApiCore.Models;

namespace QuotesApiCore.Data
{
    public class QutesDbContext : DbContext
    {
     public QutesDbContext(DbContextOptions<QutesDbContext>options):base(options)
        {

        }
        public DbSet<Quote> Quotes { get; set; }
    }
}
