﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWcf
{
    public class Book
    {   [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string bookId { get; set; }
     
        public string bookName { get; set; }
      
        public string publishYear { get; set; }
        
        public double price { get; set; }
       
        public int  quantity{ get; set; }

         public string authorName { get; set; }
        

      

         public string catId { get; set; }
         [ForeignKey("catId")]

         public category catgories { get; set; }

    }
}
