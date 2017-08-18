namespace University.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployeeCategoryFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "EmployeeCategory_Id", "dbo.EmployeeCategories");
            DropIndex("dbo.Employees", new[] { "EmployeeCategory_Id" });
            RenameColumn(table: "dbo.Employees", name: "EmployeeCategory_Id", newName: "EmployeeCategoryId");
            AlterColumn("dbo.Employees", "EmployeeCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "EmployeeCategoryId");
            AddForeignKey("dbo.Employees", "EmployeeCategoryId", "dbo.EmployeeCategories", "Id", cascadeDelete: true);
            DropColumn("dbo.Employees", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "CategoryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Employees", "EmployeeCategoryId", "dbo.EmployeeCategories");
            DropIndex("dbo.Employees", new[] { "EmployeeCategoryId" });
            AlterColumn("dbo.Employees", "EmployeeCategoryId", c => c.Int());
            RenameColumn(table: "dbo.Employees", name: "EmployeeCategoryId", newName: "EmployeeCategory_Id");
            CreateIndex("dbo.Employees", "EmployeeCategory_Id");
            AddForeignKey("dbo.Employees", "EmployeeCategory_Id", "dbo.EmployeeCategories", "Id");
        }
    }
}
