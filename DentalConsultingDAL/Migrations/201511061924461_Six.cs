namespace DentalConsultingDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Six : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DentalCard", "Reason", c => c.String());
            AddColumn("dbo.DentalCard", "GeneralStateOfHealth", c => c.String());
            AddColumn("dbo.DentalCard", "ConfigurationFace", c => c.String());
            AddColumn("dbo.DentalCard", "SkinCovering", c => c.String());
            AddColumn("dbo.DentalCard", "LymphNodes", c => c.String());
            AddColumn("dbo.DentalCard", "TemporalJoint", c => c.String());
            AddColumn("dbo.DentalCard", "Bite", c => c.String());
            DropColumn("dbo.DentalCard", "DentalCardContent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DentalCard", "DentalCardContent", c => c.String());
            DropColumn("dbo.DentalCard", "Bite");
            DropColumn("dbo.DentalCard", "TemporalJoint");
            DropColumn("dbo.DentalCard", "LymphNodes");
            DropColumn("dbo.DentalCard", "SkinCovering");
            DropColumn("dbo.DentalCard", "ConfigurationFace");
            DropColumn("dbo.DentalCard", "GeneralStateOfHealth");
            DropColumn("dbo.DentalCard", "Reason");
        }
    }
}
