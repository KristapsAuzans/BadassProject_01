using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatDatingSite.Models
{
    public class Blog
    
    {
        [Key]
        public int BlogID { get; set; }

        [Required]
        public string Email {get; set;}

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }
        public DateTime BlogCreated { get; set; }
        public DateTime BlogModified { get; set; }
        
        
    }
}