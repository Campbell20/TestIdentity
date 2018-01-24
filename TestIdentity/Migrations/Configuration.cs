namespace TestIdentity.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    //internal sealed class Configuration : DbMigrationsConfiguration<TestIdentity.Models.ApplicationDbContext>
    internal sealed class Configuration : DbMigrationsConfiguration<TestIdentity.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //ContextKey = "TestIdentity.Models.ApplicationDbContext";
            ContextKey = "TestIdentity.Data.ApplicationDbContext";
        }

        //protected override void Seed(TestIdentity.Models.ApplicationDbContext context)
        protected override void Seed(TestIdentity.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
