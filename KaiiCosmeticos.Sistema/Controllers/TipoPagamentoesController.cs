using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KaiiCosmeticos.Sistema.Data;
using KaiiCosmeticos.Sistema.Models;
using Microsoft.AspNetCore.Authorization;

namespace KaiiCosmeticos.Sistema.Controllers
{
    [Authorize]
    public class TipoPagamentoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoPagamentoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TipoPagamentoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoPagamento.ToListAsync());
        }

        // GET: TipoPagamentoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPagamento = await _context.TipoPagamento
                .FirstOrDefaultAsync(m => m.IdPagamento == id);
            if (tipoPagamento == null)
            {
                return NotFound();
            }

            return View(tipoPagamento);
        }

        // GET: TipoPagamentoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoPagamentoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPagamento,Descricao")] TipoPagamento tipoPagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoPagamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoPagamento);
        }

        // GET: TipoPagamentoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPagamento = await _context.TipoPagamento.FindAsync(id);
            if (tipoPagamento == null)
            {
                return NotFound();
            }
            return View(tipoPagamento);
        }

        // POST: TipoPagamentoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPagamento,Descricao")] TipoPagamento tipoPagamento)
        {
            if (id != tipoPagamento.IdPagamento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoPagamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoPagamentoExists(tipoPagamento.IdPagamento))
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
            return View(tipoPagamento);
        }

        // GET: TipoPagamentoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPagamento = await _context.TipoPagamento
                .FirstOrDefaultAsync(m => m.IdPagamento == id);
            if (tipoPagamento == null)
            {
                return NotFound();
            }

            return View(tipoPagamento);
        }

        // POST: TipoPagamentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoPagamento = await _context.TipoPagamento.FindAsync(id);
            _context.TipoPagamento.Remove(tipoPagamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoPagamentoExists(int id)
        {
            return _context.TipoPagamento.Any(e => e.IdPagamento == id);
        }
    }
}
