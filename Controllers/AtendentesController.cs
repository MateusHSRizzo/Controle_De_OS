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
    public class AtendentesController : Controller
    {
        private readonly Contexto _context;

        public AtendentesController(Contexto context)
        {
            _context = context;
        }

        // GET: Atendentes
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Atendentes.Include(a => a.Cliente);
            return View(await contexto.ToListAsync());
        }

        // GET: Atendentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Atendentes == null)
            {
                return NotFound();
            }

            var atendente = await _context.Atendentes
                .Include(a => a.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atendente == null)
            {
                return NotFound();
            }

            return View(atendente);
        }

        // GET: Atendentes/Create
        public IActionResult Create()
        {
            ViewData["Idcliente"] = new SelectList(_context.Clientes, "Id", "documento");
            return View();
        }

        // POST: Atendentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nome,Registro,Idcliente")] Atendente atendente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(atendente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idcliente"] = new SelectList(_context.Clientes, "Id", "documento", atendente.Idcliente);
            return View(atendente);
        }

        // GET: Atendentes/Edit/5
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
            ViewData["Idcliente"] = new SelectList(_context.Clientes, "Id", "documento", atendente.Idcliente);
            return View(atendente);
        }

        // POST: Atendentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,nome,Registro,Idcliente")] Atendente atendente)
        {
            if (id != atendente.Id)
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
                    if (!AtendenteExists(atendente.Id))
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
            ViewData["Idcliente"] = new SelectList(_context.Clientes, "Id", "documento", atendente.Idcliente);
            return View(atendente);
        }

        // GET: Atendentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Atendentes == null)
            {
                return NotFound();
            }

            var atendente = await _context.Atendentes
                .Include(a => a.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atendente == null)
            {
                return NotFound();
            }

            return View(atendente);
        }

        // POST: Atendentes/Delete/5
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
          return _context.Atendentes.Any(e => e.Id == id);
        }
    }
}
