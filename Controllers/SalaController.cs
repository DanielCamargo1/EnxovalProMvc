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
            var itens = _context.Intens.ToList();
            return View(itens);
        }

        public IActionResult AdicionarItem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarItem(EnxovalModel item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }
            item.Comprado = false;
            _context.Intens.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ItemComprado(int id)
        {
            var item = _context.Intens.Find(id);
            if(item != null)
            {
                item.Comprado = true;
                item.DataDaCompra = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Index", new { anchor = "itens-comprados" });
            }
            return NotFound();
        }



    }
}
