using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace nba_project.Models
{
    public class nba_projectContext : DbContext
    {
        public nba_projectContext() : base("name=NBA_DB")
        {

        }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Division> Divisions { get; set; }
    }
}