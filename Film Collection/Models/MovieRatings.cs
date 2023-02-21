using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Collection.Models
{
    //Model for the form
    public class MovieRatings
    {
        // Primary Key
        [Key]
        [Required]
        public int MovieId { get; set; }

        // Foreign Key
        [Required(ErrorMessage ="Please enter in category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        // Other table attributes
        [Required(ErrorMessage = "Please enter in movie title")]
        public string MovieTitle { get; set; }
        [Required(ErrorMessage = "Please enter in year")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Please enter in director")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please select rating")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
    }
}
