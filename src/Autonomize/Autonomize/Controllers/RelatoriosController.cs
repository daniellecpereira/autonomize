using Autonomize.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Autonomize.Controllers {
    public class RelatoriosController : Controller {
        private readonly AppDbContext _context;

        public RelatoriosController(AppDbContext context) {
            _context = context;
        }

        // GET: Relatorios
        public async Task<IActionResult> Index() {
            return View(await _context.Relatorios.ToListAsync());
        }

        // GET: Relatorios/Create
        public async Task<IActionResult> Create() {
            ViewBag.Clientes = await _context.Clientes.ToListAsync();
            ViewBag.Produtos = await _context.Produtos.ToListAsync();

            return View();
        }

        // POST: Relatorios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Relatorio relatorio) {


            if (ModelState.IsValid) {
                switch (relatorio.TipoRelatorio) {
                    case TiposRelatorio.Registros:
                        var r = new Relatorio(
                        relatorio.Nome,
                        relatorio.TipoItem,
                        relatorio.TipoAlteracao,
                        relatorio.TipoRelatorio,
                        relatorio.DataInicio,
                        relatorio.DataFinal
                    );
                        _context.Relatorios.Add(r);
                        break;

                    case TiposRelatorio.Vendas:
                        r = new Relatorio(
                        relatorio.Nome,
                        relatorio.TipoRelatorio,
                        relatorio.DataInicio,
                        relatorio.DataFinal
                    );
                        _context.Relatorios.Add(r);
                        break;

                    default:
                        r = new Relatorio(
                        relatorio.Nome,
                        relatorio.TipoRelatorio,
                        relatorio.Itens,
                        relatorio.DataInicio,
                        relatorio.DataFinal
                    );
                        _context.Relatorios.Add(r);
                        break;
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(relatorio);
        }

        // GET: Relatorios/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var relatorio = await _context.Relatorios.FindAsync(id);
            if (relatorio == null) {
                return NotFound();
            }
            return View(relatorio);
        }

        // POST: Relatorios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Relatorio relatorio) {
            if (id != relatorio.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(relatorio);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!RelatorioExists(relatorio.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(relatorio);
        }

        public async Task<IActionResult> Cliente(int? id) {
            if (id == null) {
                return NotFound();
            }

            var relatorio = await _context.Relatorios
               .FirstOrDefaultAsync(m => m.Id == id);

            if (relatorio == null) {
                return NotFound();
            }

            if (relatorio.TipoRelatorio == TiposRelatorio.Cliente) {

                DateTime[] datasUltimaCompra = new DateTime[relatorio.Itens.Count];
                decimal[] valorMaxComprado = new decimal[relatorio.Itens.Count];
                string[] produtoMaisComprado = new string[relatorio.Itens.Count];
                decimal[] maiorCompraUnica = new decimal[relatorio.Itens.Count];
                int[] quantidadeProdutoMaisComprado = new int[relatorio.Itens.Count];
                var clientes = new List<Cliente>();
                for (int i = 0; i < relatorio.Itens.Count; i++) {
                    var cliente = await _context.Clientes
                        .Where(c => c.Id == relatorio.Itens[i])
                        .FirstOrDefaultAsync();
                    clientes.Add(cliente);
                    var vendas = await _context.Consumos.Where(v => v.ClienteId == cliente.Id)
                        .ToListAsync();
                    if (vendas.Count > 0) {
                        datasUltimaCompra[i] = vendas.OrderByDescending(v => v.Data).FirstOrDefault().Data;
                        valorMaxComprado[i] = vendas.Sum(s => s.Valor);
                        maiorCompraUnica[i] = vendas.OrderByDescending(v => v.Subtotal).FirstOrDefault().Subtotal;

                        var produtoMaisCompradoVenda = vendas.GroupBy(v => v.ProdutoId)
                            .OrderByDescending(g => g.Sum(v => v.QuantidadeVenda))
                            .Select(g => new {
                                QuantidadeTotal = g.Sum(v => v.QuantidadeVenda),
                                Nome = _context.Produtos.FirstOrDefault(p => p.Id == g.Key).Nome
                            })
                            .FirstOrDefault();
                        if (produtoMaisCompradoVenda != null) {
                            produtoMaisComprado[i] = produtoMaisCompradoVenda.Nome;
                            quantidadeProdutoMaisComprado[i] = produtoMaisCompradoVenda.QuantidadeTotal;
                        }
                    } else {
                        datasUltimaCompra[i] = DateTime.MinValue;
                        valorMaxComprado[i] = 0;
                        produtoMaisComprado[i] = "Nenhum produto comprado";
                        quantidadeProdutoMaisComprado[i] = 0;
                    }
                }
                ViewBag.DetalhesClientes = new {
                    DataUltimaCompra = datasUltimaCompra,
                    ValorMaxComprado = valorMaxComprado,
                    ProdutoMaisComprado = produtoMaisComprado,
                    MaiorCompraUnica = maiorCompraUnica,
                    QuantidadeProdutoMaisComprado = quantidadeProdutoMaisComprado
                };
                ViewBag.Cliente = clientes;
                return View(relatorio);
            }
            return View();
        }


        public async Task<IActionResult> Produtos(int? id) {
            if (id == null) {
                return NotFound();
            }

            var relatorio = await _context.Relatorios
                .FirstOrDefaultAsync(m => m.Id == id);

            if (relatorio != null) {
                return NotFound();
            }

            if (relatorio.TipoRelatorio == TiposRelatorio.Produtos) {

                var produtos = new List<Produto>();
                var quantidadeTotal = 0;
                decimal valorTotalVenda;
                decimal valorTotalCompra;
                for (int i = 0; i < produtos.Capacity; i++) {
                    var produto = await _context.Produtos.Where(p => p.Id == relatorio.Itens[i]).FirstOrDefaultAsync();
                    produtos.Add(produto);
                }

                ViewBag.DetalhesProduto = new {
                    QuantidadeTotal = quantidadeTotal,
                    ValorTotalVenda = produtos.Sum(p => p.PrecoVenda),
                    ValorTotalCompra = produtos.Sum(p => p.PrecoCompra)
                };


                return View(produtos);
            }

            return View(relatorio);
        }


        // GET: Relatorios/Vendas/5
        public async Task<IActionResult> Vendas(int? id) {
            if (id == null) {
                return NotFound();
            }

            var relatorio = await _context.Relatorios
                .FirstOrDefaultAsync(m => m.Id == id);

            if (relatorio == null) {
                return NotFound();
            }

            if (relatorio.TipoRelatorio == TiposRelatorio.Vendas) {
                var applicationDbContext = _context.Consumos.Include(v => v.Produto);
                var venda = await applicationDbContext.Where(v =>
                    v.Data >= relatorio.DataInicio
                    && v.Data <= relatorio.DataFinal
                    ).ToListAsync();

                int totalQntVendida = 0;
                decimal[] faturamentoBruto = new decimal[venda.Count];
                //decimal[] faturamentoLiq = new decimal[venda.Count];
                decimal[] reposicao = new decimal[venda.Count];
                decimal totalFaturamentoBruto = 0;
                decimal totalReposicao = 0;

                for (int i = 0; i < venda.Count; i++) {

                    var v = venda[i];

                    var produto = await _context.Produtos.FindAsync(v.ProdutoId);

                    faturamentoBruto[i] = v.Subtotal - (produto.PrecoCompra * v.QuantidadeVenda);
                    //faturamentoLiq[i] = faturamentoBruto - impostos - despesasAdministrativas
                    reposicao[i] = v.QuantidadeVenda * produto.PrecoCompra;

                    totalQntVendida += v.QuantidadeVenda;

                }
                venda.Sort((item1, item2) => item1.Data.CompareTo(item2.Data));
                totalFaturamentoBruto = faturamentoBruto.Sum();
                totalReposicao = reposicao.Sum();

                ViewBag.ListaVendas = venda;
                ViewBag.DadosRelatorio = new {
                    FaturamentoBruto = faturamentoBruto,
                    Reposicao = reposicao,
                    TotalFaturamentoBruto = totalFaturamentoBruto,
                    TotalReposicao = totalReposicao,
                    TotalQntVendida = totalQntVendida
                };

                return View(relatorio);
            }
            return View();
        }

        // GET: Relatorios/Registros/5
        public async Task<IActionResult> Registros(int? id) {
            if (id == null) {
                return NotFound();
            }

            var relatorio = await _context.Relatorios
                .FirstOrDefaultAsync(m => m.Id == id);

            if (relatorio == null) {
                return NotFound();
            }

            var historicoFiltro = await _context.Historicos
                .Where(h =>
                h.TipoItem == relatorio.TipoItem &&
                h.TipoAlteracao == relatorio.TipoAlteracao &&
                h.DataRegistro >= relatorio.DataInicio &&
                h.DataRegistro <= relatorio.DataFinal
            ).ToListAsync();

            if (relatorio == null) {
                return NotFound();
            }

            ViewBag.Relatorio = relatorio;
            return View(historicoFiltro);
        }


        // GET: Relatorios/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var relatorio = await _context.Relatorios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (relatorio == null) {
                return NotFound();
            }

            return View(relatorio);
        }

        // POST: Relatorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var relatorio = await _context.Relatorios.FindAsync(id);
            if (relatorio != null) {
                _context.Relatorios.Remove(relatorio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RelatorioExists(int id) {
            return _context.Relatorios.Any(e => e.Id == id);
        }
    }
}