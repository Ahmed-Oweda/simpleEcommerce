namespace MatrixApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyingtables2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Product", "Category_Id", "dbo.Category");
            DropIndex("dbo.Product", new[] { "Category_Id" });
            CreateTable(
                "dbo.SubCategoryLv2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubCat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubCategoryLv1", t => t.SubCat_Id)
                .Index(t => t.SubCat_Id);
            
            CreateTable(
                "dbo.SubCategoryLv1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        devices = c.String(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            AddColumn("dbo.Product", "SubCategoryLv2_Id", c => c.Int());
            CreateIndex("dbo.Product", "SubCategoryLv2_Id");
            AddForeignKey("dbo.Product", "SubCategoryLv2_Id", "dbo.SubCategoryLv2", "Id");
            DropColumn("dbo.Product", "Category_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "Category_Id", c => c.Int());
            DropForeignKey("dbo.Product", "SubCategoryLv2_Id", "dbo.SubCategoryLv2");
            DropForeignKey("dbo.SubCategoryLv2", "SubCat_Id", "dbo.SubCategoryLv1");
            DropForeignKey("dbo.SubCategoryLv1", "Category_Id", "dbo.Category");
            DropIndex("dbo.SubCategoryLv1", new[] { "Category_Id" });
            DropIndex("dbo.SubCategoryLv2", new[] { "SubCat_Id" });
            DropIndex("dbo.Product", new[] { "SubCategoryLv2_Id" });
            DropColumn("dbo.Product", "SubCategoryLv2_Id");
            DropTable("dbo.SubCategoryLv1");
            DropTable("dbo.SubCategoryLv2");
            CreateIndex("dbo.Product", "Category_Id");
            AddForeignKey("dbo.Product", "Category_Id", "dbo.Category", "Id");
        }
    }
}
