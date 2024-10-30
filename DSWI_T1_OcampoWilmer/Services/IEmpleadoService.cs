using DSWI_T1_OcampoWilmer.Models;

namespace DSWI_T1_OcampoWilmer.Services
{
    public interface IEmpleadoService
    {
        IEnumerable<Empleado> GetEmpleados(string? n = null);
    }
}
