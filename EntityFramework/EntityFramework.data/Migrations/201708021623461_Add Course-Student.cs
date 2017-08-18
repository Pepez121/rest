namespace EntityFramework.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("Courses.Course", "StudentId", c => c.Int(nullable: false));
            CreateIndex("Courses.Course", "StudentId");
            AddForeignKey("Courses.Course", "StudentId", "Students.Student", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("Courses.Course", "StudentId", "Students.Student");
            DropIndex("Courses.Course", new[] { "StudentId" });
            DropColumn("Courses.Course", "StudentId");
        }
    }
}
