using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesAplication.Models;

namespace SalesAplication.Data
{
    public class SalesAplicationContext : DbContext
    {
        public SalesAplicationContext (DbContextOptions<SalesAplicationContext> options)
            : base(options)
        {
        }

        public DbSet<SalesAplication.Models.Department> Department { get; set; }
    }
}
