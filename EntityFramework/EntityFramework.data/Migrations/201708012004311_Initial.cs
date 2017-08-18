namespace EntityFramework.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Courses.Course",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Credits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Enrollments.Enrollment",
                c => new
                    {
                        EnrollmentID = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnrollmentID)
                .ForeignKey("Courses.Course", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("Students.Student", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "Students.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(maxLength: 50),
                        FirstName = c.String(),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Enrollments.Enrollment", "StudentId", "Students.Student");
            DropForeignKey("Enrollments.Enrollment", "CourseId", "Courses.Course");
            DropIndex("Enrollments.Enrollment", new[] { "StudentId" });
            DropIndex("Enrollments.Enrollment", new[] { "CourseId" });
            DropTable("Students.Student");
            DropTable("Enrollments.Enrollment");
            DropTable("Courses.Course");
        }
    }
}
