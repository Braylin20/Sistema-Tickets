using System.ComponentModel.DataAnnotations;
namespace RegPrioridades.Models
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Descripción { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [Range(1, 31, ErrorMessage = "Debe número estar entre 1 y 31")]
        public int DíasCompromiso { get; set; }
    }
}
