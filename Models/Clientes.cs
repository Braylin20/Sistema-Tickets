using System.ComponentModel.DataAnnotations;

namespace RegPrioridades.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [RegularExpression(@"^[a-zA-Z]+", ErrorMessage = "No puede contener dígitos")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El Celular solo puede contener digitos.")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "La longitud debe ser de 10 dígitos")]
        public string? Teléfono { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El Celular solo puede contener digitos.")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "La longitud debe ser de 10 dígitos")]
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