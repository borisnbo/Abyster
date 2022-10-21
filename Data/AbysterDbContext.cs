using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abyster.Models;

namespace Abyster.Data
{
    public class AbysterDbContext : DbContext
    {
        public AbysterDbContext (DbContextOptions<AbysterDbContext> options)
            : base(options)
        {
        }

        public DbSet<Abyster.Models.Ticket> Ticket { get; set; } = default!;

        public DbSet<Abyster.Models.Parking> Parking { get; set; }

        public DbSet<Abyster.Models.Reservation> Reservation { get; set; }
    }
}
