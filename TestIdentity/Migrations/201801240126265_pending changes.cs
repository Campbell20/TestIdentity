namespace TestIdentity.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pendingchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PNCModels", "SMSKey", c => c.String());
        }
        
        public override void Down()
        {
            //DropColumn("dbo.PNCModels", "SMSKey", c => c.Int(nullable: false));
        }
    }
}
