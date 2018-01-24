namespace TestIdentity.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makesureitsgonnabuild1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PNCModels", new[] { "UserId" });
            DropPrimaryKey("dbo.PNCModels");
            AlterColumn("dbo.PNCModels", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.PNCModels", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.PNCModels", "Id");
            CreateIndex("dbo.PNCModels", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.PNCModels", new[] { "UserId" });
            DropPrimaryKey("dbo.PNCModels");
            AlterColumn("dbo.PNCModels", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.PNCModels", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.PNCModels", "UserId");
            CreateIndex("dbo.PNCModels", "UserId");
        }
    }
}
