using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatDatingSite.Models
{
    using System.Data.Entity;
    using static CatDatingSite.Models.UploadedFiles;

    public class CatDb : DbContext
    {
        public DbSet<CatProfile> CatProfiles { get; set; }

        public DbSet<Blog> Blog { get; set; }

        public DbSet<File> Files { get; set; }
    }
}