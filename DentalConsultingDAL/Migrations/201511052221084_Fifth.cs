namespace DentalConsultingDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fifth : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DentalCard", "UserID");
            RenameColumn(table: "dbo.DentalCard", name: "DentalCardID", newName: "UserID");
            RenameIndex(table: "dbo.DentalCard", name: "IX_DentalCardID", newName: "IX_UserID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.DentalCard", name: "IX_UserID", newName: "IX_DentalCardID");
            RenameColumn(table: "dbo.DentalCard", name: "UserID", newName: "DentalCardID");
            AddColumn("dbo.DentalCard", "UserID", c => c.Int(nullable: false));
        }
    }
}
