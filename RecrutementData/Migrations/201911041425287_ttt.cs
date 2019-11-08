namespace RecrutementData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ttt : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tests", newName: "Test");
            RenameTable(name: "dbo.TestMarks", newName: "TestMark");
            RenameTable(name: "dbo.Questions", newName: "Question");
            DropPrimaryKey("dbo.TestMark");
            AddColumn("dbo.TestMark", "TestMarkId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TestMark", "TestMarkId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.TestMark");
            DropColumn("dbo.TestMark", "TestMarkId");
            AddPrimaryKey("dbo.TestMark", new[] { "testId", "CandidatId" });
            RenameTable(name: "dbo.Question", newName: "Questions");
            RenameTable(name: "dbo.TestMark", newName: "TestMarks");
            RenameTable(name: "dbo.Test", newName: "Tests");
        }
    }
}
