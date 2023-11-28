using Microsoft.AspNetCore.Mvc;

namespace Asp_net_core_empty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Display()
        {
            return "display method";
        }

        public int DisplayID(int id) {

            return id;

        }
    }
}
