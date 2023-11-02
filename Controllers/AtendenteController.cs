using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Controle_De_OS.Models;

namespace Controle_De_OS.Controllers
{
    public class AtendenteController : Controller
    {
        private readonly Contexto _context;

        public AtendenteController(Contexto context)
        {
            _context = context;
        }

        // GET: Atendente
        public async Task<IActionResult> Index()
        {
              return View(await _context.Atendentes.ToListAsync());
        }

        // GET: Atendente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Atendentes == null)
            {
                return NotFound();
            }

            var atendente = await _context.Atendentes
                .FirstOrDefaultAsync(m => m.Idatendente == id);
            if (atendente == null)
            {
                return NotFound();
            }

            return View(atendente);
        }

        // GET: Atendente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Atendente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idatendente,nome,codigo_atendente")] Atendente atendente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(atendente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(atendente);
        }

        // GET: Atendente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Atendentes == null)
            {
                return NotFound();
            }

            var atendente = await _context.Atendentes.FindAsync(id);
            if (atendente == null)
            {
                return NotFound();
            }
            return View(atendente);
        }

        // POST: Atendente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idatendente,nome,codigo_atendente")] Atendente atendente)
        {
            if (id != atendente.Idatendente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(atendente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtendenteExists(atendente.Idatendente))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(atendente);
        }

        // GET: Atendente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Atendentes == null)
            {
                return NotFound();
            }

            var atendente = await _context.Atendentes
                .FirstOrDefaultAsync(m => m.Idatendente == id);
            if (atendente == null)
            {
                return NotFound();
            }

            return View(atendente);
        }

        // POST: Atendente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Atendentes == null)
            {
                return Problem("Entity set 'Contexto.Atendentes'  is null.");
            }
            var atendente = await _context.Atendentes.FindAsync(id);
            if (atendente != null)
            {
                _context.Atendentes.Remove(atendente);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtendenteExists(int id)
        {
          return _context.Atendentes.Any(e => e.Idatendente == id);
        }
    }
}
