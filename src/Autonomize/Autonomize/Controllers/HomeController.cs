using Autonomize.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Autonomize.Controllers {
    public class HomeController : Controller {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context) {
            _context = context;
        }
        public IActionResult Index() {
            var model = new Models.ViewModels.DashboardViewModel {
                TotalVendas = _context.Consumos.Count(),
                TotalClientes = _context.Clientes.Count(),
                TotalProdutos = _context.Produtos.Count(),
                ValorTotalVendido = _context.Consumos.Sum(v => v.Valor)
            };

            return View(model);
        }


        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
