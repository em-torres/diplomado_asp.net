using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace nba_project.Models
{
    public class Division
    {
        [Key]
        public int DivisionID { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener una longitud máxima de {1} caracteres")]
        [Display(Name = "Division")]
        [Index("Division_Name_Index", IsUnique = true)]
        public string Name { get; set; }
    }
}