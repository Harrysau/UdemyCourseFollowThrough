using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UdemyCourseFollowThrough.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() 
            :base("name=DefaultConnection")
        {
        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Movies> Movies { get; set; }
    }
}