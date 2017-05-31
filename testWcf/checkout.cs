using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWcf
{
    public class checkout
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string bookId { get; set; }
        public string bookName { get; set; }

        public string userId { get; set; }
      
        public string categoryName { get; set; }
        public int quantity { get; set; }

        public double price { get; set; }

        public string authorName { get; set; }
    }
}
