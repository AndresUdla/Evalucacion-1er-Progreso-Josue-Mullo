using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Evaluacion_1er_Progreso_Josue_Mullo.Models;

    public class Evalucacion_1er_Progreso_Josue_MulloContext : DbContext
    {
        public Evalucacion_1er_Progreso_Josue_MulloContext (DbContextOptions<Evalucacion_1er_Progreso_Josue_MulloContext> options)
            : base(options)
        {
        }

        public DbSet<Evaluacion_1er_Progreso_Josue_Mullo.Models.Cliente> Cliente { get; set; } = default!;

public DbSet<Evaluacion_1er_Progreso_Josue_Mullo.Models.Recompensa> Recompensa { get; set; } = default!;

public DbSet<Evaluacion_1er_Progreso_Josue_Mullo.Models.Reserva> Reserva { get; set; } = default!;
    }
