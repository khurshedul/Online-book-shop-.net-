using DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bkStore.Controllers
{
    public class userController : Controller
    {
        //
        // GET: /user/
        [HttpGet]

        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(user user)
        {

            using (BookDbContext context = new BookDbContext())
            {
                if (ModelState.IsValid)
                {
                    context.users.Add(user);
                    context.SaveChanges();
                    return RedirectToAction("index","home");
                }
                else
                {
                    return View(user);
                }
            }

           
        }
    }
}
