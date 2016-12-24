using DataSource;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bkStore.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

       
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file != null)
            {
                NameValueCollection nvclc = Request.Form;
                string pic = nvclc["bkid"]+ ".jpg";
                //string pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(
                                       Server.MapPath("~/images/"), pic);
                // file is uploaded
                file.SaveAs(path);

                // save the image path path to the database or you can send image 
                // directly to database
                // in-case if you want to store byte[] ie. for DB
                using (MemoryStream ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                }
                
                

                using (BookDbContext context = new BookDbContext())
                {
                    Book books = new Book();
                    books.bookId=nvclc["bkid"];
                    books.bookName = nvclc["bkname"];
                    books.authorId = "1";
                    books.publishYear = nvclc["pbyear"];
                    books.quantity = Convert.ToInt32(nvclc["quantity"]);
                    books.price = Convert.ToDouble(nvclc["price"]);
                    context.Books.Add(books);
                    context.SaveChanges();



                }

            }
            // after successfully uploading redirect the user
            return Redirect("index");
        }
        public ActionResult List()
        {
            using (BookDbContext context = new BookDbContext())
            {

                return View(context.Books.ToList());
                // return View(data);

            }
        }

    }
}
