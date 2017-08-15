using System;
using System.ComponentModel.DataAnnotations;

namespace Arch.Model
{

    public class Track : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Length { get; set; }
        public string Description { get; set; }

        public int ArtistID { get; set; }
        public virtual Artist Artist { get; set; }
    }

}