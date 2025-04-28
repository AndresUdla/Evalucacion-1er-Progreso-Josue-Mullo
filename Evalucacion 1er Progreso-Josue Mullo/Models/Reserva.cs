using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluacion_1er_Progreso_Josue_Mullo.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }

        [Required(ErrorMessage = "La fecha de entrada es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime FechaReservaEntrada { get; set; }

        [Required(ErrorMessage = "La fecha de salida es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime FechaReservaSalida { get; set; }

        [Required(ErrorMessage = "El valor a pagar es obligatorio.")]
        [Range(0, int.MaxValue, ErrorMessage = "El valor debe ser un número positivo.")]
        public decimal ValorPagar { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }
    }
}
