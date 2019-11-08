namespace RecrutementData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Application", "ApplicationStatus", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Application", "ApplicationStatus", c => c.Boolean(nullable: false));
        }
    }
}
