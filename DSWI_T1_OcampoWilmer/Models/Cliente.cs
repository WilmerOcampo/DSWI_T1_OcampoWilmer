using System.ComponentModel.DataAnnotations;

namespace DSWI_T1_OcampoWilmer.Models
{
    public class Cliente
    {
        [Required, Display(Name = "ID")] public string? idCliente { get; set; }
        [Required, Display(Name = "Cliente")] public string? cliente { get; set; }
        [Required, Display(Name = "Dirección")] public string? direccion { get; set; }
        [Required, Display(Name = "País")] public string? idPais { get; set; }
        [Required, Display(Name = "Telefono")] public string? fono { get; set; }
    }
}
