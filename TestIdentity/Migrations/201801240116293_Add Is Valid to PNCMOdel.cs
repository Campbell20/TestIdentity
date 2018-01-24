namespace TestIdentity.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsValidtoPNCMOdel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PNCModels", "IsValid", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PNCModels", "IsValid");
        }
    }
}
