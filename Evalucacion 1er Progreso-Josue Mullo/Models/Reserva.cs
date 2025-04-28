using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evalucacion_1er_Progreso_Josue_Mullo.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; } // Atributo tipo int (identificador)

        [Required]
        public DateTime FechaReservaEntrada { get; set; } // Campo tipo DateTime

        [Required]
        public DateTime FechaReservaSalida { get; set; } // Campo tipo DateTime

        [Required]

        public int ValorReserva { get; set; } // Campo tipo int (valor de la reserva)

        [Required]
        public int ClienteId { get; set; } // Atributo tipo int (identificador del cliente)

        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; } // Relación con la clase Cliente



    }
}
