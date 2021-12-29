using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{

    public class Medico 
    {
        [Key]

        public int IdMedico {get; set;}
        [Required (ErrorMessage = "Debe ingresar el Nombre")]
                
        public string Nombre {get; set;}
        [Required (ErrorMessage = "Debe ingresar el Apellido")]
        
        public string Apellido {get; set;}
        [Required (ErrorMessage = "Debe ingresar una Direccion")]
        [Display (Name ="Direccion")]
        public string Direccion {get; set;}
        [Required (ErrorMessage = "Debe ingresar el Telefono")]
        [Display (Name ="Telefono")]
        public string Telefono {get; set;}
        [Required (ErrorMessage = "Debe ingresar un Email")]   
        [EmailAddress (ErrorMessage = "No es una direccion de email valida")]
        public string Email {get; set;}
        [Display (Name ="Horario Desde")]
        [DataType(DataType.Time)]
        [DisplayFormat (DataFormatString ="{0:HH:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HorarioAtencionDesde {get; set;}
        [Display (Name ="Horario Hasta")]
        [DataType(DataType.Time)]
        [DisplayFormat (DataFormatString ="{0:HH:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HorarioAtencionAntes {get; set;}

        public List<MedicoEspecialidad> MedicoEspecialidad {get; set;}

        public List<Turno> Turno {get; set;}
    }
}