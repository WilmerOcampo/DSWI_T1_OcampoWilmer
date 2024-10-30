using DSWI_T1_OcampoWilmer.Models;

namespace DSWI_T1_OcampoWilmer.Services
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetClientes(string? n = null);
    }
}
