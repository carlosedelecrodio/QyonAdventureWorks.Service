using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AdventureWorks.Domain.Entities
{
    [Table("Competitors")]
    public class Competitor
    {
        [Key]
        public int IdCompetitor { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set;  }

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
