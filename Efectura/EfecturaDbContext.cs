using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Efectura
{
    public class EfecturaDbContext : DbContext
    {
        public EfecturaDbContext(DbContextOptions<EfecturaDbContext> options) : base (options)
        {

        }

        public DbSet<User> User { get; set; }
    }
}
