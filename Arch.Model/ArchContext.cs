using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Model
{
    public class ArchContext : DbContext
    {
        public ArchContext() : base("ArchContext")
        {

        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}
