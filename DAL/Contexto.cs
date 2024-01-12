﻿using Microsoft.EntityFrameworkCore;
using RegPrioridades.Models;

namespace RegPrioridades.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Prioridades> Prioridades {  get; set; }
    }
}
