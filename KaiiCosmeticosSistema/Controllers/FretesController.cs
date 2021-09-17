using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KaiiCosmeticosSistema.Data;
using KaiiCosmeticosSistema.Models;

namespace KaiiCosmeticosSistema.Controllers
{
    public class FretesController : Controller
    {
        private readonly KaiiCosmeticosSistemaContext _context;

        public FretesController(KaiiCosmeticosSistemaContext context)
        {
            _context = context;
        }

        // GET: Fretes
        public async Task<IActionResult> Index()
        {
            var kaiiCosmeticosSistemaContext = _context.Frete.Include(f => f.Transportadora);
            return View(await kaiiCosmeticosSistemaContext.ToListAsync());
        }

        // GET: Fretes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frete = await _context.Frete
                .Include(f => f.Transportadora)
                .FirstOrDefaultAsync(m => m.IdFrete == id);
            if (frete == null)
            {
                return NotFound();
            }

            return View(frete);
        }

        // GET: Fretes/Create
        public IActionResult Create()
        {
            ViewData["TransportadoraId"] = new SelectList(_context.Set<Transportadora>(), "IdTransportadora", "IdTransportadora");
            return View();
        }

        // POST: Fretes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFrete,CodigoId,Valor,TransportadoraId")] Frete frete)
        {
            if (ModelState.IsValid)
            {
                _context.Add(frete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TransportadoraId"] = new SelectList(_context.Set<Transportadora>(), "IdTransportadora", "IdTransportadora", frete.TransportadoraId);
            return View(frete);
        }

        // GET: Fretes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frete = await _context.Frete.FindAsync(id);
            if (frete == null)
            {
                return NotFound();
            }
            ViewData["TransportadoraId"] = new SelectList(_context.Set<Transportadora>(), "IdTransportadora", "IdTransportadora", frete.TransportadoraId);
            return View(frete);
        }

        // POST: Fretes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFrete,CodigoId,Valor,TransportadoraId")] Frete frete)
        {
            if (id != frete.IdFrete)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(frete);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FreteExists(frete.IdFrete))
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
            ViewData["TransportadoraId"] = new SelectList(_context.Set<Transportadora>(), "IdTransportadora", "IdTransportadora", frete.TransportadoraId);
            return View(frete);
        }

        // GET: Fretes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frete = await _context.Frete
                .Include(f => f.Transportadora)
                .FirstOrDefaultAsync(m => m.IdFrete == id);
            if (frete == null)
            {
                return NotFound();
            }

            return View(frete);
        }

        // POST: Fretes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var frete = await _context.Frete.FindAsync(id);
            _context.Frete.Remove(frete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FreteExists(int id)
        {
            return _context.Frete.Any(e => e.IdFrete == id);
        }
    }
}
