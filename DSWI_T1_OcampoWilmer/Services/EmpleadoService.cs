using DSWI_T1_OcampoWilmer.Models;
using Microsoft.Data.SqlClient;

namespace DSWI_T1_OcampoWilmer.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IConfiguration _configuration;

        public EmpleadoService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<Empleado> GetEmpleados(string? n = null)
        {
            List<Empleado> empleados = new List<Empleado>();
            using (SqlConnection cn = new SqlConnection(_configuration["ConnectionStrings:sql"]))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("exec SP_Empleados @n", cn);
                cmd.Parameters.AddWithValue("@n", n ?? string.Empty);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    empleados.Add(new Empleado()
                    {
                        IdEmpleado = dr.GetInt32(0),
                        NomCompleto = dr.GetString(1),
                        FecNacimiento = dr.GetDateTime(2),
                        Direccion = dr.GetString(3),
                        IdDistrito = dr.GetInt32(4),
                        Telefono = dr.GetString(5),
                        IdCargo = dr.GetInt32(6),
                        FecContrata = dr.GetDateTime(7)
                    });
                }
                dr.Close();
            }
            return empleados;
        }
    }
}
