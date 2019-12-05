using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NanoStore.Models
{
    [Table("Ordenes")]
    public class Orden
    {
        [Key]
        public int OrdenID { get; set; }

        //[ForeignKey("ApplicationUsers")]
        public string ClienteID { get; set; }

        public DateTime? FechaOrden { get; set; }

        public DateTime? FechaRequerido { get; set; }

        public DateTime? FechaEntrega { get; set; }

        public int? EnviarVia { get; set; }

        [Column(TypeName = "money")]
        public decimal? Freight { get; set; }

        public string Destinatario { get; set; }

        [Column(TypeName = "ntext")]
        public string DireccionEnvio { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleOrden> DetalleOrdenes { get; set; }
        public virtual ApplicationUser ApplicationUsers { get; set; }
        //public virtual Employees Employees { get; set; }
    }
}