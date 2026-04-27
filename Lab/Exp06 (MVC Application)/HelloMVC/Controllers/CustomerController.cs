using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}