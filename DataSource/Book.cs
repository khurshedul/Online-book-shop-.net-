﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class Book
    {   [Key]
        public int bookId { get; set; }
        
        public string bookName { get; set; }
      
        public string publishYear { get; set; }
        
        public double price { get; set; }
        
         public int  quantity{ get; set; }

         public int authorId { get; set; }
         [ForeignKey("authorId")]
         public Author Author { get; set; }

    }
}
