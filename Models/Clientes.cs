using System.ComponentModel.DataAnnotations;

namespace RegPrioridades.Models
{
    public class Clientes
    {
        [Key]
        public int ClientesId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido"), StringLength(20)]
        [RegularExpression(@"^[a-zA-Z]", ErrorMessage = "No puede contener dígitos")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [RegularExpression(@"^\(829|809|849\)\d{7}", ErrorMessage = "El número de teléfono no es válido.")]
        public string? Celular { get; set; }
        [Required(ErrorMessage = "Este campo es requerido"), EmailAddress(ErrorMessage = "No es un correo válido")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [RegularExpression(@"^[1-9]{9}$", ErrorMessage = "El RNC debe contener 9 digitos")]
        public string? RNC { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Dirección { get; set; }

    }
}