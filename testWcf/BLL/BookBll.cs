using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testWcf;

namespace testWcf{
    public class BookBll
    {
        public BookEntity   GetuserTypeDetails()
        {
           BookEntity od=new BookEntity ();
            try {
                using (BookDbContext dc = new BookDbContext())
                {
                    
                    od.userlist = (from d in dc.users select d).ToList();
                   

                }

            }
            catch (Exception e)
            {

            }
            return od;
          
        }
    }
}