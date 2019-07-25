namespace MatrixApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingrecordssubcategLv1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SubCategoryLv1 (devices,Category_Id) VALUES ('mobiles',1)");
            Sql("INSERT INTO SubCategoryLv1 (devices,Category_Id) VALUES ('labtops',1)");
            Sql("INSERT INTO SubCategoryLv1 (devices,Category_Id) VALUES ('HandWatch',2)");
            Sql("INSERT INTO SubCategoryLv1 (devices,Category_Id) VALUES ('WallWatch',2)");
            Sql("INSERT INTO SubCategoryLv1 (devices,Category_Id) VALUES ('Perfumes',3)");
            Sql("INSERT INTO SubCategoryLv1 (devices,Category_Id) VALUES ('shampoos',3)");
            Sql("INSERT INTO SubCategoryLv1 (devices,Category_Id) VALUES ('Tshirts',4)");
            Sql("INSERT INTO SubCategoryLv1 (devices,Category_Id) VALUES ('trousers',4)");
        
        }
        
        public override void Down()
        {
        }
    }
}
