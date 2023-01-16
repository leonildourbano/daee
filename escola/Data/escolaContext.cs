using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using escola.Models;

namespace escola.Data
{
    public class escolaContext : DbContext
    {
        public escolaContext (DbContextOptions<escolaContext> options)
            : base(options)
        {
        }

        public DbSet<escola.Models.Aluno> Aluno { get; set; } = default!;

        public DbSet<escola.Models.Professor> Professor { get; set; }
    }
}
