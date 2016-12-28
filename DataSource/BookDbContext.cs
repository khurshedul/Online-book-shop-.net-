using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
   
        public class BookDbContext : DbContext
        {
            public DbSet<Book> Books { get; set; }
            
            public DbSet<user> users { get; set; }
            public DbSet<category> categories { get; set; }
            public DbSet<cart> carts { get; set; }
            public DbSet<checkout> checkouts { get; set; }
        }
    
}
