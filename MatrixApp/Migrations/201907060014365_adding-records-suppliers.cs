namespace MatrixApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingrecordssuppliers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Supplier (Name,PhoneNum) VALUES ('Dell',655564)");
            Sql("INSERT INTO Supplier (Name,PhoneNum) VALUES ('Rolex',6574564)");
            Sql("INSERT INTO Supplier (Name,PhoneNum) VALUES ('Samsung',2664564)");
            Sql("INSERT INTO Supplier (Name,PhoneNum) VALUES ('zara',36596655)");
            Sql("INSERT INTO Supplier (Name,PhoneNum) VALUES ('Davidoff',856364)");
            Sql("INSERT INTO Supplier (Name,PhoneNum) VALUES ('Clear',6555564)");
        }
        
        public override void Down()
        {
        }
    }
}
