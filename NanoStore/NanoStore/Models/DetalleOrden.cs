using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NanoStore.Models
{
    [Table("Detalle_Orden")]
    public class DetalleOrden
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrdenID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductoID { get; set; }

        [Column(TypeName = "money")]
        public decimal PrecioUnitario { get; set; }

        public short Cantidad { get; set; }

        public float Descuento { get; set; }


        public virtual Orden Orden { get; set; }
        public virtual Producto Producto { get; set; }
    }
}