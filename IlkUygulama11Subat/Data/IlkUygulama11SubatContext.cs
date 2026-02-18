using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IlkUygulama11Subat.Models;

namespace IlkUygulama11Subat.Data
{
    public class IlkUygulama11SubatContext : DbContext
    {
        public IlkUygulama11SubatContext (DbContextOptions<IlkUygulama11SubatContext> options)
            : base(options)
        {
        }

        public DbSet<IlkUygulama11Subat.Models.Movie> Movie { get; set; } = default!;
    }
}
