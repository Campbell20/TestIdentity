namespace TestIdentity.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedCustomFields : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PNCModels", "IsActive");
            DropColumn("dbo.PNCModels", "SMSKey");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PNCModels", "SMSKey", c => c.Int(nullable: false));
            AddColumn("dbo.PNCModels", "IsActive", c => c.Boolean(nullable: false));
        }
    }
}
