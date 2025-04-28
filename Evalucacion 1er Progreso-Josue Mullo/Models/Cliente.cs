using System;
using System.ComponentModel.DataAnnotations;

namespace Evalucacion_1er_Progreso_Josue_Mullo.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; } // Atributo tipo int (identificador)

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
        public string Nombre { get; set; } // Campo tipo string

        [Required(ErrorMessage = "Evalucacion_1er_Progreso_Josue_Mullol correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo electrónico válido.")]
        public string Email { get; set; } // Campo tipo string (validación de email)

        [Required(ErrorMessage = "El saldo es obligatorio.")]
        
        [Range(0, 1000000, ErrorMessage = "El saldo debe estar entre 0 y 1,000,000.")]
        public decimal Saldo { get; set; } // Campo tipo decimal

        [Required]
        public bool EsActivo { get; set; } // Campo tipo bool

        [Required(ErrorMessage = "Debe ingresar la fecha de registro.")]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; } // Campo tipo fecha
    }
}