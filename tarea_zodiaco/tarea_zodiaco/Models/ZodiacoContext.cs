using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace tarea_zodiaco.Models
{
    public class ZodiacoContext : DbContext
    {
        public ZodiacoContext() : base("name=Zodiaco")
        {

        }

        public DbSet<Persona> Personas { get; set; }
    }
}