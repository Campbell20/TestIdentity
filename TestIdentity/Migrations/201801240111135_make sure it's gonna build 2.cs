namespace TestIdentity.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makesureitsgonnabuild2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PNCModels", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.PNCModels", new[] { "UserId" });
            AlterColumn("dbo.PNCModels", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PNCModels", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.PNCModels", "UserId");
            AddForeignKey("dbo.PNCModels", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
