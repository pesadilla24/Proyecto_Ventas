using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Models
{
    public class VendedorContext:DbContext
    {
        public VendedorContext(DbContextOptions<VendedorContext> options) : base(options)
        {

        }

        public DbSet<Vendedor> Vendedores { get; set; }

        public DbSet<WebAPI.Models.Ciudad> Ciudad { get; set; }
    }
}
