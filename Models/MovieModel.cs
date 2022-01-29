using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_4.Models
{
    public class MovieModel
    {
        [Key]
        [Required]
        public int MovieID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }
        
        [StringLength(25, MinimumLength=0,ErrorMessage="Max 25 characters")]
        public string Notes { get; set; }

        // Build foreign key relationship
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
