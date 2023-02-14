using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdventureWorks.Application.Dtos
{
    public class RaceTrackDto
    {
        [Key]
        public int IdRaceTrack { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
