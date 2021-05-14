using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationFirst.Models;

namespace WebApplicationFirst.Data
{
    public class WebApplicationFirstContext : DbContext
    {
        public WebApplicationFirstContext (DbContextOptions<WebApplicationFirstContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationFirst.Models.Departament> Departament { get; set; }
    }
}
