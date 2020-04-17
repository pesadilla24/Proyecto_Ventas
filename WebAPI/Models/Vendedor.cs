using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Vendedor
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Apellido { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(16)")]
        public string Numero_Identificacion { get; set; }

        [Required]
        [Column(TypeName = "Integer")]
        public int Codigo_Ciudad { get; set; }

       
    }
}
