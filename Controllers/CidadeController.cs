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
    public class CidadeController : Controller
    {
        private readonly Contexto _context;

        public CidadeController(Contexto context)
        {
            _context = context;
        }

        // GET: Cidade
        public async Task<IActionResult> Index()
        {
              return View(await _context.Cidades.ToListAsync());
        }

        // GET: Cidade/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidades
                .FirstOrDefaultAsync(m => m.Idcidade == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // GET: Cidade/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cidade/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idcidade,descricao,estado")] Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cidade);
        }

        // GET: Cidade/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidades.FindAsync(id);
            if (cidade == null)
            {
                return NotFound();
            }
            return View(cidade);
        }

        // POST: Cidade/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idcidade,descricao,estado")] Cidade cidade)
        {
            if (id != cidade.Idcidade)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CidadeExists(cidade.Idcidade))
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
            return View(cidade);
        }

        // GET: Cidade/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cidades == null)
            {
                return NotFound();
            }

            var cidade = await _context.Cidades
                .FirstOrDefaultAsync(m => m.Idcidade == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        // POST: Cidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cidades == null)
            {
                return Problem("Entity set 'Contexto.Cidades'  is null.");
            }
            var cidade = await _context.Cidades.FindAsync(id);
            if (cidade != null)
            {
                _context.Cidades.Remove(cidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CidadeExists(int id)
        {
          return _context.Cidades.Any(e => e.Idcidade == id);
        }
    }
}
