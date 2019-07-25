namespace MatrixApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingrecordsproducts : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Product (Name,NoInStock,Price,SubCategoryLv2_Id,Supplier_Id) VALUES ('Samsung J7',3,4000,2,3)");
            Sql("INSERT INTO Product (Name,NoInStock,Price,SubCategoryLv2_Id,Supplier_Id) VALUES ('Tshirt',6,100,13,4)");
            Sql("INSERT INTO Product (Name,NoInStock,Price,SubCategoryLv2_Id,Supplier_Id) VALUES ('Clear-for-men',10,40,11,6)");
            Sql("INSERT INTO Product (Name,NoInStock,Price,SubCategoryLv2_Id,Supplier_Id) VALUES ('Handwatch',4,500,5,2)");
        }
        
        public override void Down()
        {
        }
    }
}
