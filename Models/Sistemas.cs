using System.ComponentModel.DataAnnotations;

namespace RegPrioridades.Models
{
    public class Sistemas
    {
        [Key]
        public int SistemaId { get; set; }
        [Required(ErrorMessage ="Este campo es requerido")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage ="Este campo es requerido")]
        public string? Descripcion { get; set; }
    }
}
