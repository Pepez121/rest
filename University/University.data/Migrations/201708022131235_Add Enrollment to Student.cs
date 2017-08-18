namespace University.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEnrollmenttoStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Enrollment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Enrollment");
        }
    }
}
