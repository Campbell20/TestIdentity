namespace TestIdentity.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PNCModels", "VerifcationKey", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PNCModels", "VerifcationKey", c => c.Int(nullable: false));
        }
    }
}
