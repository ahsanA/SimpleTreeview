using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MyCustomTreeView.Models;

namespace MyCustomTreeView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Simple()
        {
            List<Menu> all = new List<Menu>();
            using (var dc = new MyMenuContext())
            {
                all = dc.Menus.OrderBy(i=>i.ParentId).ToList(); //Menu.OrderBy(a => a.ParentMenuID).ToList();
            }
            return View(all);
        }
    }
}
