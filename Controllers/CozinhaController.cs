﻿using Microsoft.AspNetCore.Mvc;
using NossoEnxoval.Data;
using NossoEnxoval.Models;

namespace NossoEnxoval.Controllers
{
    public class CozinhaController : Controller
    {

        private readonly EnxovalDbContext _context;
        public CozinhaController(EnxovalDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var itens = _context.Itens.ToList();
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

            var item = _context.Itens.Find(id);
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

            var item = _context.Itens.Find(id);
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
            item.Comodo = "Cozinha";
            item.Descricao = "Decrição padrão";
            item.Comprado = false;
            _context.Itens.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ItemComprado(int id)
        {
            var item = _context.Itens.Find(id);
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
            item.Comodo = "Cozinha";
            item.Descricao = "Decrição padrão";
            _context.Itens.Update(item);
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
            _context.Itens.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
