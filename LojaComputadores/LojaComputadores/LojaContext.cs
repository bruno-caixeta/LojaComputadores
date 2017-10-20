﻿using LojaComputadores.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaComputadores
{   //Conexão com banco de dados
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions options) : base(options) { }

        public DbSet<Computador> Computadores { get; set; }
    }
}
