namespace EntityFramework.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManytomanyFluentAPI : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CityVendors", newName: "CityVendor");
            MoveTable(name: "dbo.CityVendor", newSchema: "University");
            RenameColumn(table: "University.CityVendor", name: "City_Id", newName: "VendorId");
            RenameColumn(table: "University.CityVendor", name: "Vendor_Id", newName: "CityId");
            RenameIndex(table: "University.CityVendor", name: "IX_City_Id", newName: "IX_VendorId");
            RenameIndex(table: "University.CityVendor", name: "IX_Vendor_Id", newName: "IX_CityId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "University.CityVendor", name: "IX_CityId", newName: "IX_Vendor_Id");
            RenameIndex(table: "University.CityVendor", name: "IX_VendorId", newName: "IX_City_Id");
            RenameColumn(table: "University.CityVendor", name: "CityId", newName: "Vendor_Id");
            RenameColumn(table: "University.CityVendor", name: "VendorId", newName: "City_Id");
            MoveTable(name: "University.CityVendor", newSchema: "dbo");
            RenameTable(name: "dbo.CityVendor", newName: "CityVendors");
        }
    }
}
