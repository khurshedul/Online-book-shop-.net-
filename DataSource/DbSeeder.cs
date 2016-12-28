using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace DataSource
{
    public class DbSeeder : DropCreateDatabaseIfModelChanges<BookDbContext>
    {
        protected override void Seed(BookDbContext context)
        {
            base.Seed(context);
          user users= new user()
            {
               
              name="admin",
              type="admin",
              username="admin",
              pass="1234",
              address="bogra",
              phone="012112110",
              email="adm@gmail.com"
              
                
            };

          checkout check = new checkout()
          {
              bookId="1",
              bookName="Harano Dinguli",
               authorName="Mr Niloy",
               categoryName="1",
               price=200,
               quantity=3,
               userId="1"
              
             





          };



          context.users.Add(users);
          context.checkouts.Add(check);
      

              context.SaveChanges();

        }
    }
}
