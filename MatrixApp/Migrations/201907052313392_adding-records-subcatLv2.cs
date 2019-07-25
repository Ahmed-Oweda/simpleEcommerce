namespace MatrixApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingrecordssubcatLv2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (1,3000)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (1,6000)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (2,8000)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (2,15000)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (3,500)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (3,1000)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (4,200)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (4,500)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (5,300)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (5,600)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (6,50)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (6,80)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (7,100)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (7,160)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (8,150)");
            Sql("INSERT INTO SubCategoryLv2 (SubCat_Id,RangeOfPrices) VALUES (8,300)");
        }
        
        public override void Down()
        {
        }
    }
}
