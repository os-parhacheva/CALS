using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options)
     : base(options)
        {
        }

       public DbSet<Achievement> Achievements { get; set; }
       public DbSet<Author> Authors { get; set; }
    }
}
