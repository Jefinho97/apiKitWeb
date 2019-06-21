using apiKitWeb.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiKitWeb.Context
{
    public class KitWebsDbContext : DbContext
    {
        public DbSet<KitNet> KitNets { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Imagem> Imagems { get; set; }

        public KitWebsDbContext(DbContextOptions<KitWebsDbContext> options): base(options)
        {

        }
    }
}
