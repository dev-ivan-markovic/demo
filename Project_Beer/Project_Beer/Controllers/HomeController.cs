using System.Web.Mvc;

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