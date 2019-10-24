using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace practica_primera_clase.Models
{
    public class practica_primera_claseContext : DbContext
    {
        public practica_primera_claseContext() : base("name=practicaASP")
        {

        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Area> Areas { get; set; }
    }
}