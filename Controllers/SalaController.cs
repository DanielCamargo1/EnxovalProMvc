using Microsoft.AspNetCore.Mvc;
using NossoEnxoval.Data;
using NossoEnxoval.Models;

namespace NossoEnxoval.Controllers
{
    public class SalaController: Controller
    {

        private readonly EnxovalDbContext _context;
        public SalaController(EnxovalDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdicionarItem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarItem(EnxovalModel item)
        {
            _context.Intens.Add(item);
            _context.SaveChanges();
            return View("Indexe");
        }



    }
}
