namespace DentalConsultingDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateArticle : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Article", "ArticleTitle", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Article", "ArticleTitle", c => c.String());
        }
    }
}
