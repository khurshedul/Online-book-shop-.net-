using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string authorId { get; set; }
        
        public string authorName  { get; set; }

        public List<Book> Books { get; set; }
        
    }
}
