namespace MatrixApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyinftables4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Supplier", "Product_Id", "dbo.Product");
            DropIndex("dbo.Supplier", new[] { "Product_Id" });
            AddColumn("dbo.Product", "Supplier_Id", c => c.Int());
            CreateIndex("dbo.Product", "Supplier_Id");
            AddForeignKey("dbo.Product", "Supplier_Id", "dbo.Supplier", "Id");
            DropColumn("dbo.Supplier", "Product_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Supplier", "Product_Id", c => c.Int());
            DropForeignKey("dbo.Product", "Supplier_Id", "dbo.Supplier");
            DropIndex("dbo.Product", new[] { "Supplier_Id" });
            DropColumn("dbo.Product", "Supplier_Id");
            CreateIndex("dbo.Supplier", "Product_Id");
            AddForeignKey("dbo.Supplier", "Product_Id", "dbo.Product", "Id");
        }
    }
}
