﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tekman.Repository.Models;

namespace Tekman.Repository
{
    
    public class TekmanDBContext : DbContext
    {
        public TekmanDBContext(DbContextOptions<TekmanDBContext> options)
            : base(options) { }

        public DbSet<Actividad> Actividad { get; set; }
        public DbSet<Competencia> Competencia { get; set; }
        public DbSet<Ejercicio> Ejercicio { get; set; }
        public DbSet<Pregunta> Pregunta { get; set; }

    }
}
