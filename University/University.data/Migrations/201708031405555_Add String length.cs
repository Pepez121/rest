namespace University.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStringlength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employees", "Enrollment", c => c.String(maxLength: 6));
            AlterColumn("dbo.Employees", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employees", "LastName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "LastName", c => c.String());
            AlterColumn("dbo.Employees", "FirstName", c => c.String());
            AlterColumn("dbo.Employees", "Enrollment", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
        }
    }
}
