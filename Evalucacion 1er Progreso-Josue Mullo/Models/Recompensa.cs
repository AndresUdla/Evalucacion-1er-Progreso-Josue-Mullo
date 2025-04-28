using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evalucacion_1er_Progreso_Josue_Mullo.Models
{
    public class Recompensa
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public string FechaInicio { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Los puntos deben ser un número positivo.")]
        public int PuntosAcumulados { get; set; }

        [Required]
        
        public int TipoRecompensa { get; set; } // 1: SILVER, 2: GOLD

        [Required]
        public int ClienteId { get; set; }


        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; } // Relación con la clase Cliente


    }
}
