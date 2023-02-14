using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdventureWorks.Domain.Entities
{
    public class RaceTrack
    {
        [Key]
        public int IdRaceTrack { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
