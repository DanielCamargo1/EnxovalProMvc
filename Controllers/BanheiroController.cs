using Microsoft.AspNetCore.Mvc;
using NossoEnxoval.Data;
using NossoEnxoval.Models;

namespace NossoEnxoval.Controllers
{
    public class BanheiroController : Controller
    {

        private readonly EnxovalDbContext _context;
        public BanheiroController(EnxovalDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var itens = _context.Banheiro.ToList();
            return View(itens);
        }

        public IActionResult AdicionarItem()
        {
            return View();
        }

        public IActionResult EditarItem(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var item = _context.Banheiro.Find(id);
            if (item != null)
            {
                return View(item);
            }
            return NotFound();
        }

        public IActionResult ExcluirItem(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var item = _context.Banheiro.Find(id);
            if (item != null)
            {
                return View(item);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AdicionarItem(EnxovalModel item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }
            item.Comprado = false;
            _context.Banheiro.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ItemComprado(int id)
        {
            var item = _context.Banheiro.Find(id);
            if (item != null)
            {
                item.Comprado = true;
                item.DataDaCompra = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Index", new { anchor = "itens-comprados" });
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult EditarItem(EnxovalModel item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }
            _context.Banheiro.Update(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ExcluirItem(EnxovalModel item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }
            _context.Banheiro.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
