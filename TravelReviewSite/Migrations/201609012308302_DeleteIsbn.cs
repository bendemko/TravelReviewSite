namespace TravelReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIsbn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Post", c => c.String());
            DropColumn("dbo.Reviews", "Description");
            DropColumn("dbo.Reviews", "ISBN");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "ISBN", c => c.String());
            AddColumn("dbo.Reviews", "Description", c => c.String());
            DropColumn("dbo.Reviews", "Post");
        }
    }
}
