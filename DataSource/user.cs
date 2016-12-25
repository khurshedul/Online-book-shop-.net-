using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class user
    {   [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string type { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
    }
}
