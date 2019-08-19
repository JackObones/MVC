using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Webapp.Models
{
    public class WebappContext : DbContext
    {
        public WebappContext (DbContextOptions<WebappContext> options)
            : base(options)
        {
        }

        public DbSet<Webapp.Models.Department> Department { get; set; }
    }
}
