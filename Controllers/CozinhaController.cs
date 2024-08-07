using Microsoft.AspNetCore.Mvc;

namespace NossoEnxoval.Controllers
{
    public class CozinhaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
