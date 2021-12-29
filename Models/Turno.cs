using System;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Turno
    {
        [Key]
        public int IdTurno { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        [Display (Name ="Fecha Hora ini.")]
        public DateTime fechaHoraInicio { get; set; }
        [Display (Name ="Fecha Hora fin")]
        public DateTime fechaHoraFin { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }

    }
}