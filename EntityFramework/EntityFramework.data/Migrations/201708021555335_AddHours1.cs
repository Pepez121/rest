namespace EntityFramework.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHours1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Students.Student", "GroupId", c => c.Int(nullable: false));
            AddColumn("StudentAddresses.StudentAddress", "State", c => c.String(maxLength: 20));
            CreateIndex("Students.Student", "GroupId");
            AddForeignKey("Students.Student", "GroupId", "dbo.Groups", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Students.Student", "GroupId", "dbo.Groups");
            DropIndex("Students.Student", new[] { "GroupId" });
            DropColumn("StudentAddresses.StudentAddress", "State");
            DropColumn("Students.Student", "GroupId");
            DropTable("dbo.Groups");
        }
    }
}
