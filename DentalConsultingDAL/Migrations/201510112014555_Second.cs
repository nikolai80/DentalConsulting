namespace DentalConsultingDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Article", "UserUserID", c => c.Int(nullable: false));
            AlterColumn("dbo.User", "LoggedUserId", c => c.String());
            CreateIndex("dbo.Article", "UserUserID");
            AddForeignKey("dbo.Article", "UserUserID", "dbo.User", "UserID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Article", "UserUserID", "dbo.User");
            DropIndex("dbo.Article", new[] { "UserUserID" });
            AlterColumn("dbo.User", "LoggedUserId", c => c.Guid(nullable: false));
            DropColumn("dbo.Article", "UserUserID");
        }
    }
}
