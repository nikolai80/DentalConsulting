namespace DentalConsultingDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChatMessage",
                c => new
                    {
                        ChatMessageID = c.Int(nullable: false, identity: true),
                        MessageText = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                        ChatID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChatMessageID)
                .ForeignKey("dbo.Chat", t => t.ChatID, cascadeDelete: true)
                .Index(t => t.ChatID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChatMessage", "ChatID", "dbo.Chat");
            DropIndex("dbo.ChatMessage", new[] { "ChatID" });
            DropTable("dbo.ChatMessage");
        }
    }
}
