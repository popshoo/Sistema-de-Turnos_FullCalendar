using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public partial class Paciente
    {
        [Key]

        public int IdPaciente {get; set;}
        [Required(ErrorMessage ="Debe de ingresar un Nombre")]
        public string Nombre {get; set;} 
        [Required(ErrorMessage ="Debe de ingresar un Apellido")]
        public string Apellido {get; set;}
        [Required(ErrorMessage ="Debe de ingresar una Direccion")]
        [Display(Name ="Direccion")]
        public string Direccion {get; set;}
        [Required(ErrorMessage ="Debe de ingresar un Telefono")]
        [Display(Name ="Telefono")]
        public string Telefono {get; set;}
        [Required(ErrorMessage ="Debe de ingresar el correo electronico")]
        [EmailAddress(ErrorMessage ="no es una direccion de email valida")]
        public string Email {get; set;}

        public List<Turno> Turno {get; set;}
    }
}