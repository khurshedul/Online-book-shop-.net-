using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWcf
{
    public class user
    {   [Key]
        public int id { get; set; }
        [Required(ErrorMessage="Name cant be empty")]
        public string name { get; set; }
        [Required(ErrorMessage = "Username cant be empty")]
        public string username { get; set; }
       
        public string type { get; set; }

        
        [Required(ErrorMessage = "Email cant be empty")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
         [Required(ErrorMessage = "Password cant be empty")]
        public string pass { get; set; }
         [Required(ErrorMessage = "Address cant be empty")]
        public string address { get; set; }
         [Required(ErrorMessage = "Phone cant be empty")]
        public string phone { get; set; }
    }
}
