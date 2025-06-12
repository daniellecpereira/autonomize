﻿using Autonomize.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Autonomize.Controllers {
    public class ProdutosController : Controller {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context) {
            _context = context;
        }

        // GET: Produtos
        public async Task<IActionResult> Index() {
            var appDbContext = _context.Produtos.Include(p => p.TiposProduto);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.TiposProduto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null) {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create() {
            ViewData["TiposProdutoId"] = new SelectList(_context.TipoProdutos, "Id", "Nome");
            return View();
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,QuantidadeEstoque,Descricao,PrecoCompra,PrecoVenda,TiposProdutoId,DataCadastro,Ativo")] Produto produto) {
            if (ModelState.IsValid) {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TiposProdutoId"] = new SelectList(_context.TipoProdutos, "Id", "Nome", produto.TiposProdutoId);
            return View(produto);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null) {
                return NotFound();
            }
            ViewData["TiposProdutoId"] = new SelectList(_context.TipoProdutos, "Id", "Nome", produto.TiposProdutoId);
            return View(produto);
        }

        // POST: Produtos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,QuantidadeEstoque,Descricao,PrecoCompra,PrecoVenda,TiposProdutoId,DataCadastro,Ativo")] Produto produto) {
            if (id != produto.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!ProdutoExists(produto.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TiposProdutoId"] = new SelectList(_context.TipoProdutos, "Id", "Nome", produto.TiposProdutoId);
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.TiposProduto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null) {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null) {
                _context.Produtos.Remove(produto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id) {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}