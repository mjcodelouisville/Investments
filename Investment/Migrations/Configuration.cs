namespace Investment.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Investment.Models.CompanyDBContext>

    //internal sealed class Configuration : DbMigrationsConfiguration<Investment.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Investment.Models.CompanyDBContext context)
        {
  
        }
    }
}
