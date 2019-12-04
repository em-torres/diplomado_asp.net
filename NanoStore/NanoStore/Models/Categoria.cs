using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NanoStore.Controllers
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }

        [Required]
        public string NombreCategoria { get; set; }

        public bool EstadoCategoria { get; set; }
    }
}