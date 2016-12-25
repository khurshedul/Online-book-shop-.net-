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

        public ActionResult Index()
        {

            using (BookDbContext context = new BookDbContext())
            {

                return View(context.Books.ToList());
                // return View(data);

            }
        }
        public ActionResult cart()
        {
            return View();
            
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Login(HttpRequest req)
        {
            NameValueCollection nvclc = Request.Form;
            string name =nvclc["uname"];
            string pass = nvclc["pass"];
            using (BookDbContext context = new BookDbContext())
            {
                user user = context.users.SingleOrDefault(d => d.username == name && d.pass==pass);
                if (user != null)
                {
                    return RedirectToAction("index");
                    
                }
                else
                    return RedirectToAction("Login");
            }
            

        }

    }

}
