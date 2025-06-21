using Autonomize.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Autonomize.Controllers {
    public class ClientesController : Controller {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context) {
            _context = context;

        }


        public async Task<IActionResult> Index() {
            var dados = await _context.Clientes.ToListAsync();
            return View(dados);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente) {
            if (ModelState.IsValid) {

                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();
                return Redirect("SaveCreateHistorico");
            }

            return View(cliente);
        }

        [HttpGet]
        public async Task<IActionResult> SaveCreateHistorico() {
            var a = await _context.Clientes.ToListAsync();
            var cliente = a.LastOrDefault();

            var historico = new Historico(TiposItem.Cliente, TiposAlteracao.Create, cliente.Id, cliente.Nome, DateTime.Now);
            _context.Historicos.Add(historico);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id) {
            if (id == null)
                return NotFound();

            var dados = await _context.Clientes.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);

        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cliente cliente) {
            if (id != cliente.Id)
                return NotFound();

            if (ModelState.IsValid) {
                var historico = new Historico(TiposItem.Cliente, TiposAlteracao.Edit, cliente.Id, cliente.Nome, DateTime.Now);
                _context.Historicos.Add(historico);
                _context.Clientes.Update(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();

        }

        public async Task<IActionResult> Details(int? id) {
            if (id == null)
                return NotFound();
            var dados = await _context.Clientes.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }



        public async Task<IActionResult> Delete(int? id) {
            if (id == null)
                return NotFound();
            var dados = await _context.Clientes.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id) {
            if (id == null)
                return NotFound();
            var dados = await _context.Clientes.FindAsync(id);
            if (dados == null)
                return NotFound();
            var historico = new Historico(TiposItem.Cliente, TiposAlteracao.Delete, dados.Id, dados.Nome, DateTime.Now);
            _context.Historicos.Add(historico);
            _context.Clientes.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAllConfirmed(int[] ids) {


            foreach (var item in ids) {
                var cliente = await _context.Clientes.FindAsync(item);
                if (cliente != null) {
                    _context.Clientes.Remove(cliente);
                    var historico = new Historico(TiposItem.Cliente, TiposAlteracao.Delete, item, cliente.Nome, DateTime.Now);
                    _context.Historicos.Add(historico);
                }

            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}