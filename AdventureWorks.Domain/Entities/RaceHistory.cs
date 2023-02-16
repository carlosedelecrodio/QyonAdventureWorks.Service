using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AdventureWorks.Domain.Entities
{
    public class RaceHistory
    {
        [Key]
        public int IdRaceHistory { get; set; }

        [Required]
        public int IdCompetitor { get; set; }

        [Required]
        public int IdRaceTrack { get; set; }

        [Required]
        public DateTime RaceDate { get; set; }

        [Required]
        public double TimeSpent { get; set; }
    }
}
