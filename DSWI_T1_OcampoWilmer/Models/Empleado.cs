using System.ComponentModel.DataAnnotations;

namespace DSWI_T1_OcampoWilmer.Models
{
    public class Empleado
    {
        [Display(Name = "ID")]
        public int IdEmpleado { get; set; }
        [Display(Name = "Empleado")]
        public string? NomCompleto { get; set; }
        [Display(Name = "Fec Nacimiento"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FecNacimiento { get; set; }
        [Display(Name = "Dirección")]
        public string? Direccion { get; set; }
        [Display(Name = "ID Distrito")]
        public int IdDistrito { get; set; }
        [Display(Name = "Telefono")]
        public string? Telefono { get; set; }
        [Display(Name = "ID Cargo")]
        public int IdCargo { get; set; }
        [Display(Name = "Fec Contrata"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FecContrata { get; set; }


    }
}
