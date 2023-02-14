using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdventureWorks.Application.Dtos
{
    public class RaceHistoryDto
    {
        [Key]
        public int IdRaceHistory { get; set; }

        [Required]
        [ForeignKey("Competitors")]
        public int IdCompetitor { get; set; }

        [Required]
        public int IdRaceTrack { get; set; }

        [Required]
        public DateTime RaceDate { get; set; }

        [Required]
        public double TimeSpent { get; set; }
    }
}
