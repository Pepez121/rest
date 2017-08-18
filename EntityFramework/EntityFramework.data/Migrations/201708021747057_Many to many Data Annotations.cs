namespace EntityFramework.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManytomanyDataAnnotations : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cities", newName: "DA_City");
            RenameTable(name: "dbo.Vendors", newName: "DA_Vendor");
            RenameTable(name: "dbo.CityVendors", newName: "DA_VendorDA_City");
            RenameColumn(table: "dbo.DA_VendorDA_City", name: "City_Id", newName: "DA_City_Id");
            RenameColumn(table: "dbo.DA_VendorDA_City", name: "Vendor_Id", newName: "DA_Vendor_Id");
            RenameIndex(table: "dbo.DA_VendorDA_City", name: "IX_Vendor_Id", newName: "IX_DA_Vendor_Id");
            RenameIndex(table: "dbo.DA_VendorDA_City", name: "IX_City_Id", newName: "IX_DA_City_Id");
            DropPrimaryKey("dbo.DA_VendorDA_City");
            AddPrimaryKey("dbo.DA_VendorDA_City", new[] { "DA_Vendor_Id", "DA_City_Id" });
            DropColumn("dbo.DA_City", "VendorId");
            DropColumn("dbo.DA_Vendor", "CityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DA_Vendor", "CityId", c => c.Int(nullable: false));
            AddColumn("dbo.DA_City", "VendorId", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.DA_VendorDA_City");
            AddPrimaryKey("dbo.DA_VendorDA_City", new[] { "City_Id", "Vendor_Id" });
            RenameIndex(table: "dbo.DA_VendorDA_City", name: "IX_DA_City_Id", newName: "IX_City_Id");
            RenameIndex(table: "dbo.DA_VendorDA_City", name: "IX_DA_Vendor_Id", newName: "IX_Vendor_Id");
            RenameColumn(table: "dbo.DA_VendorDA_City", name: "DA_Vendor_Id", newName: "Vendor_Id");
            RenameColumn(table: "dbo.DA_VendorDA_City", name: "DA_City_Id", newName: "City_Id");
            RenameTable(name: "dbo.DA_VendorDA_City", newName: "CityVendors");
            RenameTable(name: "dbo.DA_Vendor", newName: "Vendors");
            RenameTable(name: "dbo.DA_City", newName: "Cities");
        }
    }
}
