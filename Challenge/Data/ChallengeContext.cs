using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Models
{
    public class ChallengeContext : DbContext
    {
        public ChallengeContext (DbContextOptions<ChallengeContext> options)
            : base(options)
        {
        }

        public DbSet<Challenge.Models.Machine> Machine { get; set; }
    }
}
