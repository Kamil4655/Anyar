using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anyar.Controllers
{
    public class HomeController : Controller
    {
    
        public ActionResult Index()
        {
            return View();
        }
    }
}
