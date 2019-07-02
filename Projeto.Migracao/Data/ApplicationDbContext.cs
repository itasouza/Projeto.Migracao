using Microsoft.EntityFrameworkCore;
using Projeto.Migracao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Migracao.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

    }
}
