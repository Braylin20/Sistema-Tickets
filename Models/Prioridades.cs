using System.ComponentModel.DataAnnotations;
namespace RegPrioridades.Models
{
    public class Prioridades
    {
        [Key]
        private int PrioridadId {  get; set; }
        [Required (ErrorMessage ="El campo es requerido")]
        private string Descripción { get; set; }
        [Required(ErrorMessage ="El campo es requerido")]
        [Range(1,31, ErrorMessage ="Debe número estar entre 1 y 31")]
        private int DíasCompromiso { get; set; }

    }
}
