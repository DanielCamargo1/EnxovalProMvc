using Microsoft.AspNetCore.Mvc;
using NossoEnxoval.Models;
using System.Diagnostics;
using NossoEnxoval.Data;

namespace NossoEnxoval.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EnxovalDbContext _context;

        public HomeController(ILogger<HomeController> logger, EnxovalDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var todosItens = _context.Sala.ToList()
         .Concat(_context.Cozinha.ToList())
         .Concat(_context.Quarto.ToList())
         .Concat(_context.Banheiro.ToList())
         .ToList();

            return View(todosItens);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
