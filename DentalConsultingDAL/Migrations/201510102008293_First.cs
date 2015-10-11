namespace DentalConsultingDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advice",
                c => new
                    {
                        AdviceID = c.Int(nullable: false, identity: true),
                        AdviceText = c.String(),
                    })
                .PrimaryKey(t => t.AdviceID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        LoggedUserId = c.Guid(nullable: false),
                        UserName = c.String(),
                        UserSurname = c.String(),
                        UserDateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Chat",
                c => new
                    {
                        ChatID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ChatID);
            
            CreateTable(
                "dbo.DentalCard",
                c => new
                    {
                        DentalCardID = c.Int(nullable: false),
                        DentalCardContent = c.String(),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DentalCardID)
                .ForeignKey("dbo.User", t => t.DentalCardID)
                .Index(t => t.DentalCardID);
            
            CreateTable(
                "dbo.HospitalChart",
                c => new
                    {
                        HospitalChartID = c.Int(nullable: false),
                        HospitalChartContent = c.String(),
                    })
                .PrimaryKey(t => t.HospitalChartID)
                .ForeignKey("dbo.User", t => t.HospitalChartID)
                .Index(t => t.HospitalChartID);
            
            CreateTable(
                "dbo.Reminder",
                c => new
                    {
                        ReminderID = c.Int(nullable: false, identity: true),
                        ReminderText = c.String(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ReminderID)
                .ForeignKey("dbo.User", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        RoleTitle = c.String(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.TestResult",
                c => new
                    {
                        TestResultID = c.Int(nullable: false, identity: true),
                        TestResultText = c.String(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.TestResultID)
                .ForeignKey("dbo.User", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.ArticleContent",
                c => new
                    {
                        ArticleID = c.Int(nullable: false),
                        ArticleText = c.String(),
                    })
                .PrimaryKey(t => t.ArticleID)
                .ForeignKey("dbo.Article", t => t.ArticleID)
                .Index(t => t.ArticleID);
            
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        ArticleID = c.Int(nullable: false, identity: true),
                        ArticleTitle = c.String(),
                    })
                .PrimaryKey(t => t.ArticleID);
            
            CreateTable(
                "dbo.UserAdvice",
                c => new
                    {
                        User_UserID = c.Int(nullable: false),
                        Advice_AdviceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserID, t.Advice_AdviceID })
                .ForeignKey("dbo.User", t => t.User_UserID, cascadeDelete: true)
                .ForeignKey("dbo.Advice", t => t.Advice_AdviceID, cascadeDelete: true)
                .Index(t => t.User_UserID)
                .Index(t => t.Advice_AdviceID);
            
            CreateTable(
                "dbo.ChatUser",
                c => new
                    {
                        Chat_ChatID = c.Int(nullable: false),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Chat_ChatID, t.User_UserID })
                .ForeignKey("dbo.Chat", t => t.Chat_ChatID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.User_UserID, cascadeDelete: true)
                .Index(t => t.Chat_ChatID)
                .Index(t => t.User_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArticleContent", "ArticleID", "dbo.Article");
            DropForeignKey("dbo.TestResult", "User_UserID", "dbo.User");
            DropForeignKey("dbo.Role", "UserID", "dbo.User");
            DropForeignKey("dbo.Reminder", "User_UserID", "dbo.User");
            DropForeignKey("dbo.HospitalChart", "HospitalChartID", "dbo.User");
            DropForeignKey("dbo.DentalCard", "DentalCardID", "dbo.User");
            DropForeignKey("dbo.ChatUser", "User_UserID", "dbo.User");
            DropForeignKey("dbo.ChatUser", "Chat_ChatID", "dbo.Chat");
            DropForeignKey("dbo.UserAdvice", "Advice_AdviceID", "dbo.Advice");
            DropForeignKey("dbo.UserAdvice", "User_UserID", "dbo.User");
            DropIndex("dbo.ChatUser", new[] { "User_UserID" });
            DropIndex("dbo.ChatUser", new[] { "Chat_ChatID" });
            DropIndex("dbo.UserAdvice", new[] { "Advice_AdviceID" });
            DropIndex("dbo.UserAdvice", new[] { "User_UserID" });
            DropIndex("dbo.ArticleContent", new[] { "ArticleID" });
            DropIndex("dbo.TestResult", new[] { "User_UserID" });
            DropIndex("dbo.Role", new[] { "UserID" });
            DropIndex("dbo.Reminder", new[] { "User_UserID" });
            DropIndex("dbo.HospitalChart", new[] { "HospitalChartID" });
            DropIndex("dbo.DentalCard", new[] { "DentalCardID" });
            DropTable("dbo.ChatUser");
            DropTable("dbo.UserAdvice");
            DropTable("dbo.Article");
            DropTable("dbo.ArticleContent");
            DropTable("dbo.TestResult");
            DropTable("dbo.Role");
            DropTable("dbo.Reminder");
            DropTable("dbo.HospitalChart");
            DropTable("dbo.DentalCard");
            DropTable("dbo.Chat");
            DropTable("dbo.User");
            DropTable("dbo.Advice");
        }
    }
}
