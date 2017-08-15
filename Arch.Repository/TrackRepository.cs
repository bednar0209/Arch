using Arch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Arch.Repository
{
    public class TrackRepository : GenericRepository<Track>, ITrackRepository
    {
        public TrackRepository(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// Connect Tracks with Artists
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Track> GetAll()
        {
            return _context.Set<Track>().Include(x => x.Artist).AsEnumerable();
        }
    }
}
