using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class category
    {   [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string catId { get; set; }
        public string catName { get; set; }

    }
}
