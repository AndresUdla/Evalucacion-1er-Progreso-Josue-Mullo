using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluacion_1er_Progreso_Josue_Mullo.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El saldo es obligatorio.")]
        [Range(0, 10000, ErrorMessage = "El saldo debe estar entre 0 y 10,000.")]
        public decimal Saldo { get; set; }

        [Required(ErrorMessage = "Debe indicar si el cliente está activo.")]
        public bool Activo { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
        public ICollection<Recompensa> Recompensas { get; set; } = new List<Recompensa>();
    }
}
