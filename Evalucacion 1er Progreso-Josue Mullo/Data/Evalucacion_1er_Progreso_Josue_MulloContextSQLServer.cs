using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Evalucacion_1er_Progreso_Josue_Mullo.Models;

    public class Evalucacion_1er_Progreso_Josue_MulloContextSQLServer : DbContext
    {
        public Evalucacion_1er_Progreso_Josue_MulloContextSQLServer (DbContextOptions<Evalucacion_1er_Progreso_Josue_MulloContextSQLServer> options)
            : base(options)
        {
        }

        public DbSet<Evalucacion_1er_Progreso_Josue_Mullo.Models.Cliente> Cliente { get; set; } = default!;

public DbSet<Evalucacion_1er_Progreso_Josue_Mullo.Models.Recompensa> Recompensa { get; set; } = default!;

public DbSet<Evalucacion_1er_Progreso_Josue_Mullo.Models.Reserva> Reserva { get; set; } = default!;
    }
