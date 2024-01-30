
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
        [Range(1, int.MaxValue, ErrorMessage = "Selecciona una Cliente")]
        public int ClientesId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Selecciona una Sistema")]
        [ForeignKey("Sistemas")]
        public int SistemaId { get; set; }
        [ForeignKey("Prioridades")]
        [Range(1, int.MaxValue, ErrorMessage = "Selecciona una Prioridad")]
        public int PrioridadesId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? SolicitadoPor { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Asunto { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Descripcion { get; set; }
    }
}
