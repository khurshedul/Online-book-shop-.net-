using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataSource;
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

    }

}
