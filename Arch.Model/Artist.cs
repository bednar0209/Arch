using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Arch.Model
{
    public class Artist : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public virtual IEnumerable<Track> Tracks { get; set; }

    }
}
