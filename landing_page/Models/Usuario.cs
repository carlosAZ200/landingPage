using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;


namespace landing_page.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [MinLength(10, ErrorMessage = "El Nombre de usuario debe tener al menos 10 caracteres")]
        public string Nombre { get; set; }

        [EmailAddress(ErrorMessage = "Debe ingresar un mail válido")]
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }

        [Required(ErrorMessage = "La ciudad es obligatoria")]
        public string Ciudad { get; set; }
        
    }
}