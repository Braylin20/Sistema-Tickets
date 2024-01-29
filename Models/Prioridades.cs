using System.ComponentModel.DataAnnotations;
namespace RegPrioridades.Models
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public int DíasCompromiso { get; set; }
    }
}
