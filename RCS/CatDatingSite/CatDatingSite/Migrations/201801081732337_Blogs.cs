namespace CatDatingSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Blogs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Title = c.String(nullable: false),
                        Text = c.String(nullable: false),
                        BlogCreated = c.DateTime(nullable: false),
                        BlogModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BlogID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Blogs");
        }
    }
}
