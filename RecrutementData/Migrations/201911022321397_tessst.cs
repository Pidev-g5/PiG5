namespace RecrutementData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tessst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        Contenu = c.String(),
                        NbrLike = c.Int(nullable: false),
                        NbrComment = c.Int(nullable: false),
                        Titre = c.String(),
                        Photo = c.String(),
                        DatePost = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.BlogId)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        Contenu = c.String(),
                        BlogId = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.BlogId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        LName = c.String(),
                        Address = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Countries = c.Int(nullable: false),
                        Role = c.String(),
                        BirthDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Photo = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(precision: 7, storeType: "datetime2"),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                        Candidat_WebSite = c.String(),
                        Candidat_Bio = c.String(),
                        Candidat_facebookLink = c.String(),
                        Candidat_linkedInLink = c.String(),
                        Candidat_TwitterLink = c.String(),
                        StatusCandidate = c.Int(),
                        TestId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tests", t => t.TestId)
                .Index(t => t.TestId);
            
            CreateTable(
                "dbo.CustomUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.CustomUserLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.CustomUserRoles",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Id = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Users", t => t.Id, cascadeDelete: true)
                .ForeignKey("dbo.CustomRoles", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Certifications",
                c => new
                    {
                        Cerfication_Id = c.Int(nullable: false, identity: true),
                        Cerfication_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Cerfication_Link = c.String(),
                        Cerfication_Name = c.String(),
                        Candidat_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Cerfication_Id)
                .ForeignKey("dbo.Users", t => t.Candidat_Id, cascadeDelete: true)
                .Index(t => t.Candidat_Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Education_Id = c.Int(nullable: false, identity: true),
                        Education_Name = c.String(),
                        Education_StartDate = c.Int(nullable: false),
                        Education_EndDate = c.Int(nullable: false),
                        Education_Location = c.String(),
                        Education_Description = c.String(),
                        Candidat_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Education_Id)
                .ForeignKey("dbo.Users", t => t.Candidat_Id, cascadeDelete: true)
                .Index(t => t.Candidat_Id);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        TestId = c.Int(nullable: false, identity: true),
                        TestName = c.String(),
                        TypeTest = c.Int(nullable: false),
                        StatusTest = c.Int(nullable: false),
                        DateTest = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.TestId);
            
            CreateTable(
                "dbo.TestMarks",
                c => new
                    {
                        testId = c.Int(nullable: false),
                        CandidatId = c.Int(nullable: false),
                        mark = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.testId, t.CandidatId })
                .ForeignKey("dbo.Users", t => t.CandidatId, cascadeDelete: true)
                .ForeignKey("dbo.Tests", t => t.testId, cascadeDelete: true)
                .Index(t => t.testId)
                .Index(t => t.CandidatId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QstId = c.Int(nullable: false, identity: true),
                        qQst = c.String(),
                        Rep1 = c.String(),
                        Rep2 = c.String(),
                        Rep3 = c.String(),
                        Rep4 = c.String(),
                        RepCorrect = c.String(),
                        TestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QstId)
                .ForeignKey("dbo.Tests", t => t.TestId, cascadeDelete: true)
                .Index(t => t.TestId);
            
            CreateTable(
                "dbo.WorkExperiences",
                c => new
                    {
                        WorkExperience_Id = c.Int(nullable: false, identity: true),
                        WorkExperience_Name = c.String(),
                        WorkExperience_StartDate = c.Int(nullable: false),
                        WorkExperience_EndDate = c.Int(nullable: false),
                        WorkExperience_Location = c.String(),
                        WorkExperience_Description = c.String(),
                        Candidat_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WorkExperience_Id)
                .ForeignKey("dbo.Users", t => t.Candidat_Id, cascadeDelete: true)
                .Index(t => t.Candidat_Id);
            
            CreateTable(
                "dbo.Claims",
                c => new
                    {
                        ClaimId = c.Int(nullable: false, identity: true),
                        Object_claim = c.String(),
                        Content_claim = c.String(),
                        Type_claim = c.String(),
                        Date_claim = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        TreatmentDate_claim = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        State_claim = c.String(),
                        UserId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ClaimId)
                .ForeignKey("dbo.Users", t => t.UserId_Id)
                .Index(t => t.UserId_Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        IdComapny = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.Int(nullable: false),
                        Website = c.String(),
                        Since = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Teamsize = c.Int(nullable: false),
                        City = c.String(),
                        Address = c.String(),
                        Description = c.String(),
                        Country = c.Int(nullable: false),
                        linkedin = c.String(),
                        Facebook = c.String(),
                        Twitter = c.String(),
                        Google = c.String(),
                        Followers = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdComapny);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        IdJob = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        PostedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Deadline = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        JobType = c.Int(nullable: false),
                        Experience = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        Industry = c.String(),
                        Salary = c.Single(nullable: false),
                        Qualification = c.Int(nullable: false),
                        CompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.IdJob)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Discussions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        p_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.p_Id)
                .Index(t => t.p_Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        MessageDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        d_id = c.Int(),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.Discussions", t => t.d_id)
                .Index(t => t.d_id);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        LikeId = c.Int(nullable: false, identity: true),
                        BlogId = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.LikeId)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.BlogId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.CustomRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomUserRoles", "Id", "dbo.CustomRoles");
            DropForeignKey("dbo.Likes", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Likes", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.Discussions", "p_Id", "dbo.Users");
            DropForeignKey("dbo.Messages", "d_id", "dbo.Discussions");
            DropForeignKey("dbo.Jobs", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Claims", "UserId_Id", "dbo.Users");
            DropForeignKey("dbo.Blogs", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Comments", "User_Id", "dbo.Users");
            DropForeignKey("dbo.WorkExperiences", "Candidat_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "TestId", "dbo.Tests");
            DropForeignKey("dbo.Questions", "TestId", "dbo.Tests");
            DropForeignKey("dbo.TestMarks", "testId", "dbo.Tests");
            DropForeignKey("dbo.TestMarks", "CandidatId", "dbo.Users");
            DropForeignKey("dbo.Educations", "Candidat_Id", "dbo.Users");
            DropForeignKey("dbo.Certifications", "Candidat_Id", "dbo.Users");
            DropForeignKey("dbo.CustomUserRoles", "Id", "dbo.Users");
            DropForeignKey("dbo.CustomUserLogins", "UserId", "dbo.Users");
            DropForeignKey("dbo.CustomUserClaims", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Likes", new[] { "User_Id" });
            DropIndex("dbo.Likes", new[] { "BlogId" });
            DropIndex("dbo.Messages", new[] { "d_id" });
            DropIndex("dbo.Discussions", new[] { "p_Id" });
            DropIndex("dbo.Jobs", new[] { "CompanyId" });
            DropIndex("dbo.Claims", new[] { "UserId_Id" });
            DropIndex("dbo.WorkExperiences", new[] { "Candidat_Id" });
            DropIndex("dbo.Questions", new[] { "TestId" });
            DropIndex("dbo.TestMarks", new[] { "CandidatId" });
            DropIndex("dbo.TestMarks", new[] { "testId" });
            DropIndex("dbo.Educations", new[] { "Candidat_Id" });
            DropIndex("dbo.Certifications", new[] { "Candidat_Id" });
            DropIndex("dbo.CustomUserRoles", new[] { "Id" });
            DropIndex("dbo.CustomUserLogins", new[] { "UserId" });
            DropIndex("dbo.CustomUserClaims", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "TestId" });
            DropIndex("dbo.Comments", new[] { "User_Id" });
            DropIndex("dbo.Comments", new[] { "BlogId" });
            DropIndex("dbo.Blogs", new[] { "User_Id" });
            DropTable("dbo.CustomRoles");
            DropTable("dbo.Likes");
            DropTable("dbo.Messages");
            DropTable("dbo.Discussions");
            DropTable("dbo.Jobs");
            DropTable("dbo.Companies");
            DropTable("dbo.Claims");
            DropTable("dbo.WorkExperiences");
            DropTable("dbo.Questions");
            DropTable("dbo.TestMarks");
            DropTable("dbo.Tests");
            DropTable("dbo.Educations");
            DropTable("dbo.Certifications");
            DropTable("dbo.CustomUserRoles");
            DropTable("dbo.CustomUserLogins");
            DropTable("dbo.CustomUserClaims");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.Blogs");
        }
    }
}
