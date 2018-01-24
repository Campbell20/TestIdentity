namespace TestIdentity.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedIsValidtoIsActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PNCModels", "IsActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.PNCModels", "IsValid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PNCModels", "IsValid", c => c.Boolean(nullable: false));
            DropColumn("dbo.PNCModels", "IsActive");
        }
    }
}
