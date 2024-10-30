using DSWI_T1_OcampoWilmer.Models;
using Microsoft.Data.SqlClient;

namespace DSWI_T1_OcampoWilmer.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IConfiguration _configuration;

        public ClienteService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<Cliente> GetClientes(string? n = null)
        {
            List<Cliente> clientes = new List<Cliente>();
            using (SqlConnection cn = new SqlConnection(_configuration["ConnectionStrings:sql"]))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("exec SP_Clientes @n", cn);
                cmd.Parameters.AddWithValue("@n", n ?? string.Empty);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    clientes.Add(new Cliente()
                    {
                        idCliente = dr.GetString(0),
                        cliente = dr.GetString(1),
                        direccion = dr.GetString(2),
                        idPais = dr.GetString(3),
                        fono = dr.GetString(4)
                    });
                }
                dr.Close();
            }
            return clientes;
        }
    }
}
