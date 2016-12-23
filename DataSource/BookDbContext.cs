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
            public DbSet<Author> Authors { get; set; }
        }
    
}
