﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatDatingSite.Models
{
    using System.ComponentModel.DataAnnotations;
    public class UploadedFiles
    {
        public class File
        {
            public int FileId { get; set; }
            [StringLength(255)]
            public string FileName { get; set; }
            [StringLength(100)]
            public string ContentType { get; set; }
            public byte[] Content { get; set; }
            public int CatProfileIe { get; set; }
            [Required]
            public virtual CatProfile CatProfile { get; set; }
        }
    }
}