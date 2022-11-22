using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JWST.Models;

namespace JWST.Data
{
    public class JWSTContext : DbContext
    {
        public JWSTContext (DbContextOptions<JWSTContext> options)
            : base(options)
        {
        }

        public DbSet<JWST.Models.Users> Users { get; set; } = default!;

        public DbSet<JWST.Models.importantFacts> importantFacts { get; set; }
    }
}
