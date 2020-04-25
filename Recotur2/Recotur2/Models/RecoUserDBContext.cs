using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recotur2.Models
{
    public class RecoUserDBContext:DbContext
    {
        public RecoUserDBContext(DbContextOptions<RecoUserDBContext> options) : base(options) { }
        
        public DbSet<DCandidato> DCandidatos { get; set; }

    }
}
