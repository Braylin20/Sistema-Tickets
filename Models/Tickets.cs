
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegPrioridades.Models
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime Fecha { get; set; }
        [ForeignKey("Clientes")]
        public int ClientesId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int SistemaId { get; set; }
        [ForeignKey("Prioridades")]
        public int PrioridadesId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? SolicitadoPor { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Asunto { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Descripcion { get; set; }
    }
}
