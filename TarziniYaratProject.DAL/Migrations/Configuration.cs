namespace TarziniYaratProject.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TarziniYaratProject.DAL.Concrete.EntityFramework.TarziniYaratDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TarziniYaratProject.DAL.Concrete.EntityFramework.TarziniYaratDBContext context)
        {
            throw new Exception("Migration Seed");
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
