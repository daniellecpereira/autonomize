using Autonomize.Models;
using Autonomize.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Autonomize.Controllers {
    public class VendasController : Controller {
        private readonly AppDbContext _context;

        public VendasController(AppDbContext context) {
            _context = context;
        }

        // GET: Vendas
        public async Task<IActionResult> Index() {
            var appDbContext = _context.Consumos.Include(v => v.Produto).Include(c => c.Cliente);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Vendas/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var venda = await _context.Consumos
                .Include(v => v.Produto).Include(c => c.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (venda == null) {
                return NotFound();
            }

            return View(venda);
        }

        // GET: Vendas/Create
        public async Task<IActionResult> Create() {
            ViewBag.Produtos = await _context.Produtos.Select(p => new ProdutoViewModel {
                Id = p.Id,
                Nome = p.Nome,
                Preco = p.PrecoVenda
            }).ToListAsync();

            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome");

            return View();
        }

        // POST: Vendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,QuantidadeVenda,Valor,Subtotal,ProdutoId,ClienteId,Tipo")] Venda venda) {
            if (venda == null) {
                return NotFound();
            }
            // Buscar o produto selecionado
            var produto = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == venda.ProdutoId);

            if (ModelState.IsValid) {
                if (produto != null) {
                    venda.Valor = produto.PrecoVenda;
                    var novaQuantidade = produto.QuantidadeEstoque - venda.QuantidadeVenda;
                    produto.QuantidadeEstoque = novaQuantidade;
                } else {
                    ModelState.AddModelError("ProdutoId", "Produto não encontrado.");
                    ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome", venda.ProdutoId);
                    return View(venda);
                }

                _context.Add(venda);
                await _context.SaveChangesAsync();
                return Redirect("SaveCreateHistorico");
            }

            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome", venda.ProdutoId);
            return View(venda);
        }

        [HttpGet]
        public async Task<IActionResult> SaveCreateHistorico() {
            var applicationDbContext = _context.Consumos.Include(v => v.Produto);
            var a = await applicationDbContext.ToListAsync();
            var venda = a.LastOrDefault();

            var produto = await _context.Produtos.FindAsync(venda.ProdutoId);
            var historico = new Historico(TiposItem.Venda, TiposAlteracao.Create, venda.Id, produto.Nome, DateTime.Now, venda.QuantidadeVenda);
            _context.Historicos.Add(historico);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Vendas/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var venda = await _context.Consumos.FindAsync(id);
            if (venda == null) {
                return NotFound();
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome", venda.ProdutoId);
            return View(venda);
        }

        // POST: Vendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cliente,Data,Valor,QuantidadeVenda,Tipo,ProdutoId")] Venda venda) {
            if (id != venda.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    var produto = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == venda.ProdutoId);
                    var historico = new Historico(TiposItem.Venda, TiposAlteracao.Edit, venda.Id, produto.Nome, DateTime.Now, venda.QuantidadeVenda);

                    venda.Valor = produto.PrecoVenda;
                    var novaQuantidade = produto.QuantidadeEstoque - venda.QuantidadeVenda;
                    produto.QuantidadeEstoque = novaQuantidade;

                    _context.Historicos.Add(historico);
                    _context.Update(venda);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!VendaExists(venda.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome", venda.ProdutoId);
            return View(venda);
        }

        // GET: Vendas/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var venda = await _context.Consumos
                .Include(v => v.Produto).Include(c => c.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venda == null) {
                return NotFound();
            }

            return View(venda);
        }

        // POST: Vendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var venda = await _context.Consumos.FindAsync(id);
            if (venda != null) {
                _context.Consumos.Remove(venda);
            }
            var produto = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == venda.ProdutoId);
            var historico = new Historico(TiposItem.Venda, TiposAlteracao.Delete, id, produto.Nome, DateTime.Now, venda.QuantidadeVenda);
            _context.Historicos.Add(historico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaExists(int id) {
            return _context.Consumos.Any(e => e.Id == id);
        }
    }
}