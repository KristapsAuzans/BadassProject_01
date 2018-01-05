using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatDatingSite.Models
{
    using System.ComponentModel.DataAnnotations;
    using static CatDatingSite.Models.UploadedFiles;

    public class CatProfile
    {
        [Key]
        public int CatID { get; set; }

        [Display(Name = "Kaķa vārds")]
        [Required(ErrorMessage = "Kaķim noteikti jābūt vārdam")]
        public string CatName { get; set; }

        [Display(Name = "Kaķa vecums")]
        [Range(1, 20, ErrorMessage = "Kaķa vecumam jābūt no 1 līdz 20 gadiem")]
        public int CatAge { get; set; }

        [Display(Name = "Kaķa attēls")]
        public string CatImage { get; set; }

        [Display(Name = "Kaķa apraksts")]
        public string CatDescription { get; set; }

        public virtual File profilePicture  {get; set; } 

    }
}