using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApiServer.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
    }

    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base(@"Data Source=LSTK231296\SQLEXPRESS;Initial Catalog=Company;Trusted_Connection=True;")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}