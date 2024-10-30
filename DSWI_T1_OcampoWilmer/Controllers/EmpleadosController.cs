using DSWI_T1_OcampoWilmer.Models;
using DSWI_T1_OcampoWilmer.Services;
using Microsoft.AspNetCore.Mvc;

namespace DSWI_T1_OcampoWilmer.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly IEmpleadoService _empleadoService;

        public EmpleadosController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }

        public async Task<IActionResult> Empleados(string? n = null, int p = 0)
        {
            IEnumerable<Empleado> empleados = _empleadoService.GetEmpleados(n);

            int fila = 15;
            int c = empleados.Count();
            int pags = c % fila == 0 ? c / fila : c / fila + 1;

            ViewBag.n = n;
            ViewBag.p = p;
            ViewBag.pags = pags;

            return View(await Task.Run(() => empleados.Skip(fila * p).Take(fila)));
        }
    }
}
