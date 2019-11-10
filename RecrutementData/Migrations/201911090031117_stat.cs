namespace RecrutementData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Test", "StatusTest", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Test", "StatusTest", c => c.Int(nullable: false));
        }
    }
}
