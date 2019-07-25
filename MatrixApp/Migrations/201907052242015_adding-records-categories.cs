namespace MatrixApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingrecordscategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Category (Type) VALUES ('Electronic gadgets')");
            Sql("INSERT INTO Category (Type) VALUES ('Watches')");
            Sql("INSERT INTO Category (Type) VALUES ('Cosmetics')");
            Sql("INSERT INTO Category (Type) VALUES ('Clothes')");
        }
        
        public override void Down()
        {
        }
    }
}
