namespace TestIdentity.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPNCModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PNCModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsValid = c.Boolean(nullable: false),
                        VerifcationKey = c.Int(nullable: false),
                        SMSKey = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PNCModels", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.PNCModels", new[] { "UserId" });
            DropTable("dbo.PNCModels");
        }
    }
}
