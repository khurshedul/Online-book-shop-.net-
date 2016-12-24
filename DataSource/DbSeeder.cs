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
          Author author= new Author()
            {
                authorId="2",
                authorName="safayet",
              
               Books = new List<Book>()
                {
                    new Book(){
                        bookId="2",
                        bookName="Harano Valobasha",
                        publishYear="2016",
                        quantity=1,
                        price=200.0
                        
                        
                        
                    }
                }
            };


          Author author2 = new Author()
          {
              authorId="1",
              authorName = "sayem",

              Books = new List<Book>()
                {
                    new Book(){
                        bookId="3",
                        bookName="hkkhhk Valobasha",
                        publishYear="2016",
                        quantity=1,
                        price=22.0
                        
                        
                        
                    }
                }
          };
          
          context.Authors.Add(author);
          context.Authors.Add(author2);

              context.SaveChanges();

        }
    }
}
