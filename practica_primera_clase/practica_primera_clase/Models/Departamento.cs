using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace practica_primera_clase.Models
{
    public class Departamento
    {
        [Key]
        public int DepartamentoID { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener una longitud máxima de {1} caracteres")]
        [Display(Name = "Departamento")]
        [Index("Departamento_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar un {0}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Area")]
        [Index("Departamento_Area_Index", IsUnique = true)]
        public int AreaID { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar un {0}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Empresa")]
        public int EmpresaID { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Area Area { get; set; }
    }
}