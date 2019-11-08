namespace RecrutementData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class score : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Test", "score", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Test", "score");
        }
    }
}
