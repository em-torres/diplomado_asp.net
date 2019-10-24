using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace nba_project.Models
{
    public class Equipo
    {
        [Key]
        public int EquipoID { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener una longitud máxima de {1} caracteres")]
        [Display(Name = "Equipo")]
        [Index("Equipo_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar un {0}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Division")]
        public int DivisionID { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar un {0}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Estado")]
        public int EstadoID { get; set; }

        public virtual Division Division { get; set; }

        public virtual Estado Estado { get; set; }
    }
}