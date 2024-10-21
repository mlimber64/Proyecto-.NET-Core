using PruebaTecnica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PruebaTecnica.Domain.Dtos
{
    public class ConexionDBContext: DbContext
    {
        

        public ConexionDBContext(DbContextOptions<ConexionDBContext> options) : base(options) { }

        public DbSet<Cliente>? clientes { get; set; }
        public DbSet<Cuenta>? cuentas { get; set; }
        public DbSet<Movimientos>? movimientos { get; set; }


    }
}
