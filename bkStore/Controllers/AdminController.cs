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

            using (BookDbContext context = new BookDbContext())
            {
                string name =Convert.ToString(Session["name"]); 
                if (name =="admin")
                {
                    return View(context.categories.ToList());
                   
                }

                else
                    
                return RedirectToAction("Login", "home");
            }
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
                    books.authorName = nvclc["atname"];
                    books.catId = nvclc["cat"];
                    books.publishYear = nvclc["pbyear"];
                    books.quantity = Convert.ToInt32(nvclc["quantity"]);
                    books.price = Convert.ToDouble(nvclc["price"]);
                    context.Books.Add(books);
                    context.SaveChanges();



                }

            }
            // after successfully uploading redirect the user
            return RedirectToAction("List","Admin");
        }

        
        public ActionResult List()
        {
            using (BookDbContext context = new BookDbContext())
            {
                string name = Convert.ToString(Session["name"]);
                if (name == "admin")
                {
                    return View(context.Books.ToList());

                }


                else

                    return RedirectToAction("Login", "home");
                

            }
        }

        [HttpPost]
        public ActionResult List(NameValueCollection nvclc)
        {
            using (BookDbContext context = new BookDbContext())
            {
                string name = Convert.ToString(Session["name"]);
                if (name == "admin")
                {

                    
                        nvclc = Request.Form;
                        string search = nvclc["search"];
                        if (search != "")
                        {

                            Book dept = context.Books.SingleOrDefault(d => d.bookName.StartsWith(search));
                            if (dept != null)
                            {
                                ViewBag.vs += "<tr>" + "</td>" + "<td>" + dept.bookName + "</td>" + "<td>" + dept.bookId + "</td>" + "<td>" + dept.authorName + "</td>" + "<td>" + dept.price + "</td>" + "<td>" + dept.publishYear + "</td><td>" + dept.quantity + "</td>" + "</tr>";
                                return View(context.Books.ToList());
                            }

                            return View(context.Books.ToList());
                        }

                        return View(context.Books.ToList());

                }


                else

                    return RedirectToAction("Login", "home");


            }
        }


        [HttpGet]
        public ActionResult Edit(string id)
        {
            using (BookDbContext context = new BookDbContext())
            {
                string name = Convert.ToString(Session["name"]);
                if (name == "admin")
                {

                    Book dept = context.Books.SingleOrDefault(d => d.bookId == id);
                    return View(dept);
                }

                else

                    return RedirectToAction("Login", "home");
            }
        }

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            using (BookDbContext context = new BookDbContext())
            {
                Book booktoup = context.Books.SingleOrDefault(b => b.bookId == book.bookId);
                booktoup.bookName = book.bookName;
                booktoup.authorName = book.authorName;
                booktoup.price = book.price;
                booktoup.publishYear = book.publishYear;
                booktoup.quantity = book.quantity;
                
                context.SaveChanges();
            }
            return RedirectToAction("List","Admin");
        }

        [HttpGet]
        public ActionResult Details(string id)
        {
            using (BookDbContext context = new BookDbContext())
            {
                string name = Convert.ToString(Session["name"]);
                if (name == "admin")
                {
                    Book book = context.Books.SingleOrDefault(b => b.bookId == id);
                    return View(book);
                }

                else

                    return RedirectToAction("Login", "home");
            }
        }
        [HttpGet]
        public ActionResult report()
        {
            string name = Convert.ToString(Session["name"]);
            if (name == "admin")

            using (BookDbContext context = new BookDbContext())
            {
               var x= (from r in context.checkouts select r.quantity);
               if (x != null)
               {
                   int p = x.Sum();
                   ViewBag.bag = p;
                   return View(context.categories.ToList());
               }
               else
               return View(context.categories.ToList());
            }
            return RedirectToAction("login","home");
        }
        [HttpPost]
        public ActionResult report(NameValueCollection nvclc)
        {
            nvclc = Request.Form;
            string cat = nvclc["cat"];
            using (BookDbContext context = new BookDbContext())
            {
                var x = (from r in context.checkouts select r.quantity);
                int p = x.Sum();
                ViewBag.bag = p;

                var dataset2 = (from recordset in context.checkouts where recordset.categoryName == cat select recordset.quantity);
                int p1 = dataset2.Sum();
                ViewBag.cat = p1;
                return View(context.categories.ToList());
            }

        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            using (BookDbContext context = new BookDbContext())
            {
                string name = Convert.ToString(Session["name"]);
                if (name == "admin")
                {
                    Book book = context.Books.SingleOrDefault(b => b.bookId == id);
                    return View(book);
                }

                else

                    return RedirectToAction("Login", "home");
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string id)
        {
            string photoName = id + ".jpg";
            string fullPath = Request.MapPath("~/images/" + photoName);
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }
            using (BookDbContext context = new BookDbContext())
            {
                Book book = context.Books.SingleOrDefault(b => b.bookId == id);
                context.Books.Remove(book);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }


         [HttpGet]
        public ActionResult catList()
        {
            using (BookDbContext context = new BookDbContext())
            {
                string name = Convert.ToString(Session["name"]);
                if (name == "admin")
                {

                    return View(context.categories.ToList());
                    // return View(data);
                }

                else

                    return RedirectToAction("Login", "home");

            }
        }


         
        
       [HttpGet]

        public ActionResult createCat()
        {
            string name = Convert.ToString(Session["name"]);
            if (name == "admin")
            {

                return View();
            }

            else

                return RedirectToAction("Login", "home");
        }

        [HttpPost]

        public ActionResult createCat(category cat)
        {

            using (BookDbContext context = new BookDbContext())
            {
                if (ModelState.IsValid)
                {
                    context.categories.Add(cat);
                    context.SaveChanges();
                    return RedirectToAction("catList","Admin");
                }
                else
                {
                    return View(cat);
                }

            }
        }


        [HttpGet]
        public ActionResult cEdit(string id)
        {
            using (BookDbContext context = new BookDbContext())
            {
                string catName = Convert.ToString((Session["name"]));
                if (catName == "admin")
                {
                    category cat = context.categories.SingleOrDefault(c => c.catId == id);
                    return View(cat);
                }
                else

                    return RedirectToAction("Login", "home");

            }
        }


        [HttpPost]
        public ActionResult cEdit(category category)
        {
            using (BookDbContext context = new BookDbContext())
            {
                category cat = context.categories.SingleOrDefault(b => b.catId == category.catId);
                cat.catName = category.catName;

                context.SaveChanges();
            }
            return RedirectToAction("catList", "Admin");
        }


        [HttpGet]
        public ActionResult catDetails(string id)
        {
            using (BookDbContext context = new BookDbContext())
            {
                string catname = Convert.ToString(Session["name"]);
                if (catname == "admin")
                {
                    category cat = context.categories.SingleOrDefault(c => c.catId == id);
                    return View(cat);
                }

                else

                    return RedirectToAction("Login", "home");
            }
        }

        [HttpGet]

        public ActionResult catDelete(string id)
        {
            using (BookDbContext context = new BookDbContext())
            {
                string catname = Convert.ToString(Session["name"]);
                if (catname == "admin")
                {
                    category cat = context.categories.SingleOrDefault(c => c.catId == id);
                    return View(cat);
                }

                else

                    return RedirectToAction("Login", "home");
            }
        }

        [HttpPost]
        [ActionName("catDelete")]
        public ActionResult confirmDelete(string id)
        {


            using (BookDbContext context = new BookDbContext())
            {
                category cat = context.categories.SingleOrDefault(c => c.catId == id);
                context.categories.Remove(cat);
                context.SaveChanges();
            }
            return RedirectToAction("catList");
        }







        public ActionResult Logout()
        {
            Session.Remove("name");
            

            return Redirect("/home/Login");

        }
            
        
    }
}
