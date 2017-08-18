namespace University.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOnModelCreatingforOfficeandEmployeeCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "OfficeId", "dbo.Offices");
            DropIndex("dbo.Employees", new[] { "OfficeId" });
            AlterColumn("dbo.Employees", "OfficeId", c => c.Int());
            CreateIndex("dbo.Employees", "OfficeId");
            AddForeignKey("dbo.Employees", "OfficeId", "dbo.Offices", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "OfficeId", "dbo.Offices");
            DropIndex("dbo.Employees", new[] { "OfficeId" });
            AlterColumn("dbo.Employees", "OfficeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "OfficeId");
            AddForeignKey("dbo.Employees", "OfficeId", "dbo.Offices", "Id", cascadeDelete: true);
        }
    }
}
