using Autonomize.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Autonomize.Controllers {
    public class IncrementoEstoquesController : Controller {
        private readonly AppDbContext _context;

        public IncrementoEstoquesController(AppDbContext context) {
            _context = context;
        }

        // GET: IncrementoEstoques
        public async Task<IActionResult> Index() {
            var appDbContext = _context.IncrementoEstoques.Include(i => i.Produto);
            return View(await appDbContext.ToListAsync());
        }

        // GET: IncrementoEstoques/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var incrementoEstoque = await _context.IncrementoEstoques
                .Include(i => i.Produto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (incrementoEstoque == null) {
                return NotFound();
            }

            return View(incrementoEstoque);
        }

        // GET: IncrementoEstoques/Create
        public IActionResult Create() {
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome");
            return View();
        }

        // POST: IncrementoEstoques/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IncrementoEstoque incremento) {
            if (!ModelState.IsValid) {
                return View(incremento);
            }

            var produto = _context.Produtos.FirstOrDefault(p => p.Id == incremento.ProdutoId);
            if (produto == null) {
                return NotFound("Produto não encontrado.");
            }
            if (incremento.TipoOperacao == TipoOperacaoEstoque.Entrada) {
                produto.QuantidadeEstoque += incremento.Quantidade;
            } else if (incremento.TipoOperacao == TipoOperacaoEstoque.Saida) {
                if (produto.QuantidadeEstoque < incremento.Quantidade) {
                    ModelState.AddModelError("", "Estoque insuficiente para gerar saída.");
                    incremento.Produto = produto;
                    return View(incremento);

                }
                produto.QuantidadeEstoque -= incremento.Quantidade;
            }
            incremento.DataOperacao = DateTime.Now;
            _context.IncrementoEstoques.Add(incremento);

            _context.SaveChanges();

            return RedirectToAction("Index", "IncrementoEstoques");
        }

        // GET: IncrementoEstoques/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var incrementoEstoque = await _context.IncrementoEstoques.FindAsync(id);
            if (incrementoEstoque == null) {
                return NotFound();
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome", incrementoEstoque.ProdutoId);
            return View(incrementoEstoque);
        }

        // POST: IncrementoEstoques/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TipoOperacao,ProdutoId,Quantidade,MotivoOperacao,Observacao,DataOperacao")] IncrementoEstoque incrementoEstoque) {
            if (id != incrementoEstoque.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(incrementoEstoque);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!IncrementoEstoqueExists(incrementoEstoque.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome", incrementoEstoque.ProdutoId);
            return View(incrementoEstoque);
        }

        // GET: IncrementoEstoques/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var incrementoEstoque = await _context.IncrementoEstoques
                .Include(i => i.Produto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (incrementoEstoque == null) {
                return NotFound();
            }

            return View(incrementoEstoque);
        }

        // POST: IncrementoEstoques/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var incrementoEstoque = await _context.IncrementoEstoques.FindAsync(id);
            if (incrementoEstoque != null) {
                _context.IncrementoEstoques.Remove(incrementoEstoque);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncrementoEstoqueExists(int id) {
            return _context.IncrementoEstoques.Any(e => e.Id == id);
        }
    }
}