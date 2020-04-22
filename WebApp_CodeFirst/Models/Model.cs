using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_CodeFirst.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {
        }

        public DbSet<Vendedor> Vendedor { get; set; }
        public  DbSet<Ciudad> Ciudad { get; set; }
    }

    public class Vendedor   /*Clase padre */
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Numero_Identificacion { get; set; }
        
        // Creamos la relacion FK ya que un vendedor puede acceder a una ciudad por su codigo
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }

     
    }
    public class Ciudad         /*Clase hijo */
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Vendedor> Vendedores { get; set; }
    }
}
