namespace EntityFramework.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHours : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "StudentAddresses.StudentAddress",
                c => new
                    {
                        StudentAddressId = c.Int(nullable: false),
                        Address = c.String(maxLength: 50),
                        City = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.StudentAddressId)
                .ForeignKey("Students.Student", t => t.StudentAddressId)
                .Index(t => t.StudentAddressId);
            
            AddColumn("Courses.Course", "Hours", c => c.Int(nullable: false));
            AddColumn("Students.Student", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("StudentAddresses.StudentAddress", "StudentAddressId", "Students.Student");
            DropIndex("StudentAddresses.StudentAddress", new[] { "StudentAddressId" });
            DropColumn("Students.Student", "BirthDate");
            DropColumn("Courses.Course", "Hours");
            DropTable("StudentAddresses.StudentAddress");
        }
    }
}
