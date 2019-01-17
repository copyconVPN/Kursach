namespace Uchet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Buyers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Buyers", "LegalAddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Buyers", "LegalAddress", c => c.String());
            AlterColumn("dbo.Buyers", "Name", c => c.String());
        }
    }
}
