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
    public class PedidoVendasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PedidoVendasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PedidoVendas
        public async Task<IActionResult> Index()
        {
            return View(await _context.PedidoVendas.ToListAsync());
        }

        // GET: PedidoVendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoVendas = await _context.PedidoVendas
                .FirstOrDefaultAsync(m => m.IdPedido == id);
            if (pedidoVendas == null)
            {
                return NotFound();
            }

            return View(pedidoVendas);
        }

        // GET: PedidoVendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PedidoVendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPedido,DataEmissao,DataVenda,TipoFrete,Vendedor,ValorTotal,Lucro,Descontos,Status")] PedidoVendas pedidoVendas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedidoVendas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pedidoVendas);
        }

        // GET: PedidoVendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoVendas = await _context.PedidoVendas.FindAsync(id);
            if (pedidoVendas == null)
            {
                return NotFound();
            }
            return View(pedidoVendas);
        }

        // POST: PedidoVendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPedido,DataEmissao,DataVenda,TipoFrete,Vendedor,ValorTotal,Lucro,Descontos,Status")] PedidoVendas pedidoVendas)
        {
            if (id != pedidoVendas.IdPedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedidoVendas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoVendasExists(pedidoVendas.IdPedido))
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
            return View(pedidoVendas);
        }

        // GET: PedidoVendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoVendas = await _context.PedidoVendas
                .FirstOrDefaultAsync(m => m.IdPedido == id);
            if (pedidoVendas == null)
            {
                return NotFound();
            }

            return View(pedidoVendas);
        }

        // POST: PedidoVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedidoVendas = await _context.PedidoVendas.FindAsync(id);
            _context.PedidoVendas.Remove(pedidoVendas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoVendasExists(int id)
        {
            return _context.PedidoVendas.Any(e => e.IdPedido == id);
        }
    }
}
