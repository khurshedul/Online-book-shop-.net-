using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class Author
    {
        [Key]
        public int authorId { get; set; }
        
        public string authorName  { get; set; }

        public List<Book> Books { get; set; }
        
    }
}
