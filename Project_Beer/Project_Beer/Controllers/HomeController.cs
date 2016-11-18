using System.Web.Mvc;
using Project_Beer.Service;

namespace Project_Beer.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult Beer()
        {
            return PartialView();
        }
	}
}