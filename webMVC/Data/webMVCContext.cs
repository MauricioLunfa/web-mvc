using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace webMVC.Models
{
    public class webMVCContext : DbContext
    {
        public webMVCContext (DbContextOptions<webMVCContext> options)
            : base(options)
        {
        }

        public DbSet<webMVC.Models.Departamento> Departamento { get; set; }
    }
}
