namespace MatrixApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyingtables3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubCategoryLv2", "RangeOfPrices", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SubCategoryLv2", "RangeOfPrices");
        }
    }
}
