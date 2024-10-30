using DSWI_T1_OcampoWilmer.Models;
using DSWI_T1_OcampoWilmer.Services;
using Microsoft.AspNetCore.Mvc;

namespace DSWI_T1_OcampoWilmer.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<IActionResult> Clientes(string? n = null, int p = 0)
        {
            IEnumerable<Cliente> clientes = _clienteService.GetClientes(n);

            int fila = 15;
            int c = clientes.Count();
            int pags = c % fila == 0 ? c / fila : c / fila + 1;

            ViewBag.n = n;
            ViewBag.p = p;
            ViewBag.pags = pags;

            return View(await Task.Run(() => clientes.Skip(fila * p).Take(fila)));
        }
    }
}
