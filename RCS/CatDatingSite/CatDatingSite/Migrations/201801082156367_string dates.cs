namespace CatDatingSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringdates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "BlogCreated", c => c.String());
            AlterColumn("dbo.Blogs", "BlogModified", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "BlogModified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Blogs", "BlogCreated", c => c.DateTime(nullable: false));
        }
    }
}
