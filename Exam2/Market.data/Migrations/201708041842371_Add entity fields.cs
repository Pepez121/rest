namespace Market.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addentityfields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Description", c => c.String());
            AddColumn("dbo.Products", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.Suppliers", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Suppliers", "Email");
            DropColumn("dbo.Products", "Price");
            DropColumn("dbo.Categories", "Description");
        }
    }
}
