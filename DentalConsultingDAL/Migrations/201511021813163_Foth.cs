namespace DentalConsultingDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Foth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "UserSecondName", c => c.String());
            AddColumn("dbo.User", "UserSex", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "UserSex");
            DropColumn("dbo.User", "UserSecondName");
        }
    }
}
