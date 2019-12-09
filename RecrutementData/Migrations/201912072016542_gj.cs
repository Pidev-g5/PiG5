namespace RecrutementData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gj : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fixed",
                c => new
                    {
                        FixedId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Capacity = c.Int(nullable: false),
                        ReservedId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FixedId)
                .ForeignKey("dbo.Reserved", t => t.ReservedId, cascadeDelete: true)
                .Index(t => t.ReservedId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fixed", "ReservedId", "dbo.Reserved");
            DropIndex("dbo.Fixed", new[] { "ReservedId" });
            DropTable("dbo.Fixed");
        }
    }
}
