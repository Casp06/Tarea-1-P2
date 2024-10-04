using Microsoft.AspNetCore.Mvc;
using MiembrosComunidadApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiembrosComunidadApp.Controllers
{
    public class MiembrosController : Controller
    {
        private static List<MiembroDeLaComunidad> miembros = new List<MiembroDeLaComunidad>();

        public IActionResult Index()
        {
            return View(miembros);
        }

        public IActionResult Details(int id)
        {
            var miembro = miembros.FirstOrDefault(m => m.Id == id);
            if (miembro == null)
            {
                return NotFound();
            }
            return View(miembro);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MiembroDeLaComunidad miembro)
        {
            if (ModelState.IsValid)
            {
                miembro.Id = miembros.Count > 0 ? miembros.Max(m => m.Id) + 1 : 1;
                miembros.Add(miembro);
                return RedirectToAction(nameof(Index));
            }
            return View(miembro);
        }
    }
}
