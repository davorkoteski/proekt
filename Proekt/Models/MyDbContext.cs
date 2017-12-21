using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Proekt.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(): base("MyDbContext")
        {
        }
        public DbSet<UserAccount> userAccount { get; set; }
    }
}