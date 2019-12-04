using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using NanoStore.Controllers;

namespace NanoStore.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }

        [Required]
        public string NombreProducto { get; set; }

        public int? CategoriaID { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrecioUnitario { get; set; }
        
        public short? UnidadesEnAlmacen { get; set; }
        
        public bool EstadoProducto { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImagenPr { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleOrden> DetalleOrdenes { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}