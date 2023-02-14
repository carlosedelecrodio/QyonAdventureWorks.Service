using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdventureWorks.Application.Dtos
{
    public class CompetitorDto
    {
        [Key]
        public int IdCompetitor { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        public char Gender { get; set; }

        [Required]
        public double AverageTemperature { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        public double Height { get; set; }
    }
}
