using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataSource;
using System.Collections.Specialized;
namespace bkStore.Controllers
{
    public class homeController : Controller
    {
        
        //
        // GET: /home/
        [HttpGet]
        public ActionResult Index()
        {

            using (BookDbContext context = new BookDbContext())
            {

               // return View(context.Books.ToList());
                // return View(data);
                ServiceReference.TestWcfClient client = null;
                //return View(context.Books.ToList());
                return View(client.GetuserTypeDetails());

            }
        }


        [HttpPost]
        public ActionResult Index(NameValueCollection nvclc)
        {
            

            using (BookDbContext context = new BookDbContext())
            {
               
                string name = Convert.ToString(Session["name"]);
                if (name == "")
                {
                    return RedirectToAction("Login", "home");

                }

                else
                {
                    ServiceReference.TestWcfClient client=null;
                        //return View(context.Books.ToList());
                    return View(client.GetuserTypeDetails());
                        
                }
            }

        }
        [HttpGet]
        public ActionResult cart()
        {
            string name = Convert.ToString(Session["name"]);
            if (name == "")
            {
                return RedirectToAction("Login", "home");

            }

            else

            using (BookDbContext context1 = new BookDbContext())
            {
                return View(context1.carts.ToList());
            }
            
        }

        [HttpPost]
        public ActionResult cart(NameValueCollection nvclc)
        {

            nvclc = Request.Form;
             string a=nvclc["quantity"];
             int quantity = Convert.ToInt32(a);
             //int quantity = 1;
                
            string userId = nvclc["userId"];
            string bookId = nvclc["bookId"];
            string categoryName = nvclc["categoryName"];
            double price = Convert.ToDouble(nvclc["price"]);
            string authorName = nvclc["authorName"];
            string bookName = nvclc["bookName"];
            using (BookDbContext context = new BookDbContext())
            {

                
                    checkout check = new checkout();

                    check.bookId = bookId;
                    check.userId = userId;
                    check.price = price * quantity;
                    check.quantity = quantity;
                    check.authorName = authorName;
                    check.categoryName = categoryName;
                    check.bookName = bookName;



                    context.checkouts.Add(check);
                    context.SaveChanges();

                    cart cart = context.carts.SingleOrDefault(d => d.cartId == bookId);
                    context.carts.Remove(cart);
                    context.SaveChanges();
                    return Redirect("/home/cart");



            }

            return RedirectToAction("checkout", "home");

        }

        public ActionResult checkout()
        {

            string name = Convert.ToString(Session["name"]);
            if (name == "")
            {
                return RedirectToAction("Login", "home");

            }

            else

            using (BookDbContext context = new BookDbContext())
            {
                return View(context.checkouts.ToList());
            }
        }

        [HttpPost]
        public ActionResult userIndex(NameValueCollection nvclc)
        {

                
                
                    nvclc = Request.Form;
                    string id = nvclc["bid"];
                    string bname = nvclc["bname"];
                    double price = Convert.ToDouble(nvclc["price"]);
                    string aname = nvclc["aname"];
                    string userid = Convert.ToString(Session["id"]);
                    string category = nvclc["category"];
                    string publishYear = nvclc["publishYear"];

                
                    using (BookDbContext context = new BookDbContext())
                    {

                        cart cat = context.carts.SingleOrDefault(c => c.cartId == id);
                        if (cat == null)
                        {
                            cart cart = new cart();

                            cart.cartId = id;
                            cart.bookId = id;
                            cart.bookName = bname;
                            cart.authorName = aname;
                            cart.categoryName = category;
                            cart.userId = userid;
                            cart.price = price;
                            context.carts.Add(cart);
                            context.SaveChanges();

                        }

                        else
                        {
                            ViewBag.Message = "Already Added";

                            return View(context.Books.ToList());
                        }


                }

                using (BookDbContext context1 = new BookDbContext())
                {


                return View(context1.Books.ToList());
                // return View(data);

            }

        }



        [HttpGet]
        public ActionResult userIndex()
        {

            using (BookDbContext context = new BookDbContext())
            {

       
                return View(context.Books.ToList());
                // return View(data);

            }

        }
        public ActionResult Logout()
        {  
            Session.Remove("name");
            Session.Remove("cart");
            using (BookDbContext context = new BookDbContext())
            {

                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [carts]");
                 //   context.SaveChanges(); 

            }

            return Redirect("/home/Index");

        }



        [HttpGet]
        public ActionResult RemoveIteam(string id)
        {




            using (BookDbContext context = new BookDbContext())
            {

                cart cart = context.carts.SingleOrDefault(d => d.cartId == id);
                context.carts.Remove(cart);
                context.SaveChanges();
                return Redirect("/home/cart");

            }

        }


 





        [HttpGet]
        public ActionResult Login()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Login(NameValueCollection nvclc)
        {
             nvclc = Request.Form;
            string name =nvclc["uname"];
            string pass = nvclc["pass"];
            using (BookDbContext context = new BookDbContext())
            {
                user user = context.users.SingleOrDefault(d => d.username == name && d.pass==pass);
                if (user != null)
                {
                    if (user.type == "admin")
                    {
                        Session["name"] = user.username;
                        return RedirectToAction("Index","admin");
                    }

                    else
                        Session["name"] = user.username;
                    Session["id"] = user.id;
                        return RedirectToAction("userIndex", "home");

                }

                else
                    return RedirectToAction("Login");
            }
            

        }

    }

}
