namespace MatrixApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyingtables : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Category", "devices");
            DropColumn("dbo.Category", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Category", "devices", c => c.String());
        }
    }
}
