using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluacion_1er_Progreso_Josue_Mullo.Models
{
    public class Recompensa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la recompensa es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no debe superar los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "Los puntos acumulados son obligatorios.")]
        [Range(0, int.MaxValue, ErrorMessage = "Los puntos deben ser un número positivo.")]
        public int PuntosAcumulados { get; set; }

        [Required(ErrorMessage = "El tipo de recompensa es obligatorio.")]
        public string TipoRecompensa { get; set; } = "Silver"; // Valor por defecto opcional

        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }
    }
}
