
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Especialidad
    {
        [Key]
        
        public int IdEspecialidad {get; set;}
        [StringLength(200, ErrorMessage = "El campo debe tener como minimo 5 caracteres")]
        [Required (ErrorMessage = "Debe ingresar una descripcion")]
        [Display( Name = "Descripcion", Prompt = "Ingrese una Descripcion")]

        public string Descripcion {get; set;} 

        public List<MedicoEspecialidad> MedicoEspecialidad {get; set;}   
    }
}
