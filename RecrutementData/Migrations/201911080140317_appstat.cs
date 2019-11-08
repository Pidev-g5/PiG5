namespace RecrutementData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class appstat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Application", "ApplicationStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Application", "ApplicationStatus");
        }
    }
}
