﻿using System;
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
    public class TransportadorasController : Controller
    {
        private readonly KaiiCosmeticosSistemaContext _context;

        public TransportadorasController(KaiiCosmeticosSistemaContext context)
        {
            _context = context;
        }

        // GET: Transportadoras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transportadora.ToListAsync());
        }

        // GET: Transportadoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transportadora = await _context.Transportadora
                .FirstOrDefaultAsync(m => m.IdTransportadora == id);
            if (transportadora == null)
            {
                return NotFound();
            }

            return View(transportadora);
        }

        // GET: Transportadoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transportadoras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTransportadora,Nome,Descricao,Cnpj")] Transportadora transportadora)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transportadora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transportadora);
        }

        // GET: Transportadoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transportadora = await _context.Transportadora.FindAsync(id);
            if (transportadora == null)
            {
                return NotFound();
            }
            return View(transportadora);
        }

        // POST: Transportadoras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTransportadora,Nome,Descricao,Cnpj")] Transportadora transportadora)
        {
            if (id != transportadora.IdTransportadora)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transportadora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransportadoraExists(transportadora.IdTransportadora))
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
            return View(transportadora);
        }

        // GET: Transportadoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transportadora = await _context.Transportadora
                .FirstOrDefaultAsync(m => m.IdTransportadora == id);
            if (transportadora == null)
            {
                return NotFound();
            }

            return View(transportadora);
        }

        // POST: Transportadoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transportadora = await _context.Transportadora.FindAsync(id);
            _context.Transportadora.Remove(transportadora);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransportadoraExists(int id)
        {
            return _context.Transportadora.Any(e => e.IdTransportadora == id);
        }
    }
}
