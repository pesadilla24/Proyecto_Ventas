using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Ciudad
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Descripcion { get; set; }
    }
}
