namespace RecrutementData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class app : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Application",
                c => new
                    {
                        AppId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        OfferId = c.Int(nullable: false),
                        CandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AppId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Application");
        }
    }
}
