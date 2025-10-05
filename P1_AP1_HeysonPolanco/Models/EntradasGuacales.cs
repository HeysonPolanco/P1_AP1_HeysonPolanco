using System.ComponentModel.DataAnnotations;

namespace P1_AP1_HeysonPolanco.Models
{
    public class EntradasGuacales
    {
        [Key]
        public int IdEntrada { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required, StringLength(100)]
        public string NombreCliente { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal Precio { get; set; }
    }
}
